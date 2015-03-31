using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Eacrm;
using Toci.TraininigLibrary.Developers.Chmura.Common;
using Toci.TraininigLibrary.Developers.Chmura.DateTimeValidator;

namespace Toci.TraininigLibrary.Developers.Chmura.ChmuraDeparture
{
    public static class ChmuraDepartureHelpers<T> where T : DepartureEntity
    {
        public static bool CheckCorrectnessOfDates(DepartureEntity myEntity)
        {
            if (myEntity.DepartureDate > myEntity.ReturnDate)
            {
                throw new ChmuraValidationException(ChmuraExceptionMessages.ReturnBeforeDeparture);
            }
            return true;
        }
        public static bool CheckSection(DepartureEntity myEntity)
        {
            if (!ChmuraDepartureEntity.ClientSections.ContainsKey(myEntity.ClientId))
            {
                throw new ChmuraValidationLoicException(ChmuraExceptionMessages.NoSuchClient);
            }
            if (!ChmuraDepartureEntity.ClientSections[myEntity.ClientId].Contains(myEntity.SectionId))
            {
                throw new ChmuraValidationLoicException(ChmuraExceptionMessages.WrongSection);
            }
            return true;
        }
        public static bool ValidateTheDate(DepartureEntity myEntity)
        {
            DateValidator validator = new DateValidator();
            if (!validator.DateValidate(myEntity.DepartureDate.Year, myEntity.DepartureDate.Month, myEntity.DepartureDate.Day))
            {
                throw new ChmuraValidationException(ChmuraExceptionMessages.NotProperDate, "Exception occuded in date of departure.");
            }
        if (!validator.DateValidate(myEntity.ReturnDate.Year, myEntity.ReturnDate.Month, myEntity.ReturnDate.Day))
                {
                    throw new ChmuraValidationException(ChmuraExceptionMessages.NotProperDate, "Exception occuded in date of return.");
                }
            return true;
        }
        
        public static bool DateOverlaps(DepartureEntity myEntity, DepartureList<T> myList)
        {
            if (
                myList.FirstOrDefault(
                    element =>
                        (element.DepartureDate <= myEntity.DepartureDate && element.ReturnDate >= myEntity.ReturnDate) ||
                        (element.DepartureDate >= myEntity.DepartureDate && element.ReturnDate <= myEntity.ReturnDate) ||
                        (element.DepartureDate >= myEntity.DepartureDate && element.ReturnDate <= myEntity.ReturnDate)) != null
                )
            {
               throw new ChmuraValidationLoicException(ChmuraExceptionMessages.DateOverlaps);
            }
            return true;
        }
        public static int GetWeeksInterval(DepartureEntity myEntity)
        {
            return Math.Abs(myEntity.ReturnDate.Subtract(myEntity.DepartureDate).Days)/7;
        }

        public static bool CheckStatus(DepartureEntity myEntity, DepartureList<T> myList)
        {
            if (GenerateDepartureStatus(myEntity, myList) != myEntity.StatusId)
            {
                throw new ChmuraValidationLoicException(ChmuraExceptionMessages.WrongStatus, string.Format("Correct status should be: {0}", GenerateDepartureStatus(myEntity, myList)));
            }
            return true;
        }

        public static int GenerateDepartureStatus(DepartureEntity myEntity, DepartureList<T> myList)
        {
            DateTime now = new DateTime();
            now = DateTime.Now;

            if (myEntity.StatusId == 4)
            {
                return 4;
            }

            if (myList.FirstOrDefault(x => x.ClientId == myEntity.ClientId && x.StatusId==4) != null)
            {
                return 4;
            }

            if (myEntity.DepartureDate < now && myEntity.ReturnDate > now)
            {
                return 1;
            }
            else if (myEntity.DepartureDate > now && myEntity.DepartureDate < now.AddDays(7))
            {
                return 2;
            }
            else if (myEntity.DepartureDate < now && myEntity.ReturnDate < now)
            {
                return 3;
            }
            else if (myEntity.DepartureDate > now.AddDays(7) && myList.FirstOrDefault(x => x.ClientId == myEntity.ClientId) == null)
            {
                return 5;
            }
            else if (myEntity.DepartureDate > now.AddDays(7) && myList.FirstOrDefault(x => x.ClientId == myEntity.ClientId) != null)
            {
                return 5;
            }
            else
            {
                throw new ChmuraValidationException(ChmuraExceptionMessages.CantRetriveStatus);
            }
        }
    }
}

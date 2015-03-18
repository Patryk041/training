using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Eacrm;
using Toci.TraininigLibrary.Developers.Dysq.Exceptions.ErrorsMessages;
using Toci.TraininigLibrary.Developers.Dysq.Exceptions.Helpers;


namespace Toci.TraininigLibrary.Developers.Dysq.Exceptions
{
    public class DysqDeparturesList : DepartureList<DysqDepartureEntity>
    {
        
        public Dictionary<Func<DysqDeparturesList,DysqDepartureEntity,bool>, Func<DysqValidationException>> MyValidatorsList =
            new Dictionary<Func<DysqDeparturesList, DysqDepartureEntity, bool>, Func< DysqValidationException>>()
            {
                       {(list,entity)=>{return DateHelper.CheckDates(entity);}, 
                           ()=> { var choseDateErrorMessage =new DateError(); 
                       throw new DysqValidationException(choseDateErrorMessage.GetMessage(choseDateErrorMessage.GetMessage(DateError.KeyBadDate)),""); }},

                       {(list,row)=> { return DateHelper.CheckDateInterval(list,row);},
                           () =>{ var choseDateErrorMessage=new DateError();
                       throw new DysqValidationException(choseDateErrorMessage.GetMessage(choseDateErrorMessage.GetMessage(DateError.KeyDateExists)),"");}},

                       {(list,entity)=> { return (entity.SectionId==0);}, 
                           ()=> { var choseIdErrorMessage =new IdError(); 
                       throw new DysqValidationException(choseIdErrorMessage.GetMessage(choseIdErrorMessage.GetMessage(IdError.KeyBadId)),"");}},

                       {(list,entity)=> { return StatusHelper.CheckStatus(entity); }, 
                           ()=> {var choseActiveStatusErrorMessage =new StatusError();
                       throw new DysqValidationException(choseActiveStatusErrorMessage.GetMessage(choseActiveStatusErrorMessage.GetMessage(StatusError.KeyAciveStatus)),"");}},
                                           
                       {(list,entity)=> { return StatusHelper.CheckStatus(entity); },
                           ()=>{ var choseDeparturingStatus = new StatusError();
                       throw new DysqValidationException(choseDeparturingStatus.GetMessage(choseDeparturingStatus.GetMessage(StatusError.KeyDeparturingStatus)),"");}}
            };

        public override bool Add(DysqDepartureEntity element)
        {
            DysqDeparturesList list = new DysqDeparturesList();
            foreach (var validator in MyValidatorsList)
            {
                if (validator.Key(list,element))
                {
                    validator.Value.Invoke();
                }

                
            }

            
            //if (HelperOfDate.CheckDates(element))
            //{
            //    throw new DysqValidationException(DateError.GetDateMessage("Bad date."),"");
            //}

            //if (HelperOfDate.CheckDateInterval(this, element))
            //{
            //    throw new DysqValidationException(DateError.GetDateMessage("Date exists."),"");
            //}

            //if (element.SectionId == 0)
            //{
            //    throw new DysqValidationException(IdError.GetClientIdMessage("Bad Id."),"");
            //}

            //if (HelperOfStatus.CheckStatus(element))
            //{
            //    throw new DysqValidationException(StatusError.GetStatusMessage("Active status."),"");
            //}

            //if (HelperOfStatus.CheckStatus(element))
            //{
            //    throw new DysqValidationException(StatusError.GetStatusMessage("Departuring status"),"");
            //}

            base.Add(element);

            return true;
        }
    }
}

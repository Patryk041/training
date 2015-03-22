using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Eacrm;
using Toci.TraininigLibrary.Developers.Chmura.Common;

namespace Toci.TraininigLibrary.Developers.Chmura.ChmuraDeparture
{
    public class ChmuraDepartureList<T> : DepartureList<T> where T : DepartureEntity
    {
        public override bool Add(T element)
        {
            foreach (var task in ChmuraDepartureValidation<T>.ValidationTasks)
            {
                try
                {
                    task.Value.Invoke(element, this);
                }

                    //catch should be level up, so its just proof of concepts
                catch (ChmuraValidationException ex)
                {
                    ex.Msg[ChmuraLanguageEngine.GetLanguage()].ChmuraWriteErrorToLog();
                    ex.Message.ChmuraWriteErrorToLog();
                    ex.OptionalMessage.ChmuraWriteErrorToLog();
                }
                catch (ChmuraValidationLoicException ex)
                {
                    ex.Msg[ChmuraLanguageEngine.GetLanguage()].ChmuraWriteErrorToLog();
                    ex.Message.ChmuraWriteErrorToLog();
                    ex.OptionalMessage.ChmuraWriteErrorToLog();
                }
                
            }

            base.Add(element);

            return true;
        }
    }
}

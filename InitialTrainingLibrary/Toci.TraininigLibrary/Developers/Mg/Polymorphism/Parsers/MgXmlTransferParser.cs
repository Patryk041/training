using System;
using System.Collections.Generic;
using System.Linq;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Developers.Mg.Polymorphism.Parsers.Interface;


namespace Toci.TraininigLibrary.Developers.Mg.Polymorphism.Parsers
{
    public class MgXmlTransferParser : IMgTransferParser
    {
        public List<FileEntityBase> GetEntityTransfersList(string filePath)
        {
            const string supportedExtension = "XML";
            if (filePath.Substring(filePath.Length - 3, 3).ToUpper() != supportedExtension) throw new ArgumentException("PLIK NIE JEST PLIKIEM XML");

            return GetFileEntityBase(new MgXmlParserLogic<MgXmlEntities>().GetXmlData(ref filePath).MgXmlEntitiesList).ToList();

        }

        //private MgXmlParserLogic<MgXmlEntity> 

        private IEnumerable<FileEntityBase> GetFileEntityBase(MgXmlEntity[] entitiesList)
        {

            foreach (var entity in entitiesList)
            {
                var date = entity.Date.Split('-');
                yield return new FileEntityBase()
                {
                    Name = entity.Name,
                    Surname = entity.Surname,
                    Account = entity.Account,
                    Date = new DateTime(Convert.ToInt32(date[0]), Convert.ToInt32(date[1]), Convert.ToInt32(date[2])),

                };
            }
        }
    }
}

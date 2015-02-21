using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.syf.postcodevalidator.interfaces;

namespace InitialTrainingLibrary.syf.postcodevalidator
{
    public class RigthPostCodeValidator : RigthPostCodeValidatorBase
    {
        // tu walidujemy poislkie i niemieckie
        public override bool IsCodeValid(Province province, string code)
        {
            IPostCodeExtractor extractor = new PostCodeExtractor();
            var codeEntity = extractor.GetPostCode(code);

            return PostCodeValidatorFactory.CreateProvinceValidator(province).IsCodeValid(codeEntity);
        }
    }
}

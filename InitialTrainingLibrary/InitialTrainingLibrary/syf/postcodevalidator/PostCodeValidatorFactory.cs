using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.syf.postcodevalidator.interfaces;
using InitialTrainingLibrary.syf.postcodevalidator.provinces;

namespace InitialTrainingLibrary.syf.postcodevalidator
{
    public static class PostCodeValidatorFactory
    {
        private static Dictionary<Province, Func<IProvinceValidator>> validatorMap = new Dictionary
            <Province, Func<IProvinceValidator>>()
        {
            {Province.Dolnoslaskie, () => new SilesianValidator()},
            {Province.Wielkopolskie, () => new GreatPolandValidator()},
            {Province.Mazowieckie, () => new MazovianValidator()},
        };

        public static IProvinceValidator CreateProvinceValidator(Province province)
        {
            return validatorMap[province]();
        }
    }
}

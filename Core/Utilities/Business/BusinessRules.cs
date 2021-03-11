using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        //List<IResult> errorResults da diyebiliriz.
        public static IResult Run(params IResult[] logics)
        {
            //tüm iş kurallarını gez
            foreach (var logic in logics)
            {
                //kurala uymayan varsa o uymayan kuralı döndür
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}

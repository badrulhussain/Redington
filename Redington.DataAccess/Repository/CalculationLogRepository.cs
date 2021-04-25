using Newtonsoft.Json;
using Redington.DataAccess.Repository.IRepository;
using Redington.Models;
using Redington.Utility;
using System;
using System.Collections.Generic;
using System.IO;

namespace Redington.DataAccess.Repository
{
    public class CalculationLogRepository : ICalculationLogRepository
    {
        public void Create(Probability probability)
        {
            var probabilities = GetAll();
            if(probabilities == null)
            {
                probabilities = new Probabilities();
                probabilities.List = new List<Probability>();
            }
            else
            {
                probabilities.List.Add(probability);
            }

            try
            {
                var jsonToWrite = JsonConvert.SerializeObject(probabilities);

                using (var writer = new StreamWriter(Path.Combine(Environment.CurrentDirectory, SD.fileName)))
                {
                    writer.Write(jsonToWrite);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public Probabilities GetAll()
        {
            var probabilities = new Probabilities();

            string jsonFile = string.Empty;

            try
            {
                using (var reader = new StreamReader(Path.Combine(Environment.CurrentDirectory, SD.fileName)))
                {
                    jsonFile = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            probabilities = JsonConvert.DeserializeObject<Probabilities>(jsonFile);

            return probabilities;
        }
    }
}

﻿namespace Worker.Queue
{
    using King.Azure.BackgroundWorker.Data;
    using System.Diagnostics;
    using System.Threading.Tasks;

    public class CompanyProcessor : IProcessor<CompanyModel>
    {
        public Task<bool> Process(CompanyModel data)
        {
            Trace.TraceInformation("Save company to data store: '{0}/{1}'", data.Name, data.Id);

            return Task.FromResult<bool>(true);
        }
    }
}
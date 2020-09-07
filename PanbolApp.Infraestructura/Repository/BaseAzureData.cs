using System;
using System.Collections.Generic;
using System.Text;

namespace PanbolApp.Infraestructura.Repository
{
    public class BaseAzureData
    {
        private readonly string _cnnString;

        public BaseAzureData(string cnnString)
        {
            _cnnString = cnnString;
        }

        public string GetConnectionStorageAccount()
        {
            return _cnnString;
        }
    }
}

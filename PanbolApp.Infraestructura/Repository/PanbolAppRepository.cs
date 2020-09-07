using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using PanbolApp.Core.Dto;
using PanbolApp.Core.Interfaces.Repository;
using PanbolApp.Core.Model;

namespace PanbolApp.Infraestructura.Repository
{
    public class PanbolAppRepository:BaseAzureData,IPanbolAppRepository
    {
        public PanbolAppRepository(string cnnString) : base(cnnString)
        {

        }

        public string Get()
        {
            string connectionString = this.GetConnectionStorageAccount();
            string containerName = "container-panbolapp3";
            string blobName = "sample-blob";
            string filePath = "tmp/prueba.txt";

            // Get a reference to a container named "sample-container" and then create it
            BlobContainerClient container = new BlobContainerClient(connectionString, containerName);
            container.CreateIfNotExists();
            
            // Print out all the blob names
            string regreso = "";
            foreach (BlobItem blob in container.GetBlobs())
            {
                
                Console.WriteLine(blob.Name);
                regreso = regreso + ", " + blob.Name;
            }

            return regreso;
        }
        
    }
}

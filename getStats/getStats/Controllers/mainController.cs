using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getStats.Controllers {
    class mainController {
        // Location and name of the resource files
        string resourceFilesLocation = @"C:\Users\Dave\Documents\Visual Studio 2013\Projects_deinonichus\getStats\getStats\Resources";
        string troopsFileName = "troops.txt";
        string itemsFileName = "item_kinds1.txt";

        public void setResourceFileLocation(string resoureFileLocation) {
            this.resourceFilesLocation = resoureFileLocation;
        }
        public string getResourceFileLocation() {
            return resourceFilesLocation;
        }

        public void settroopsFileName(string troopsFileName) {
            this.troopsFileName = troopsFileName;
        }
        public string gettroopsFileName() {
            return troopsFileName;
        }

        public void setitemsFileName(string itemsFileName) {
            this.itemsFileName = itemsFileName;
        }
        public string getitemsFileName() {
            return itemsFileName;
        }



    }
}

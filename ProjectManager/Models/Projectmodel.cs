using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.Models {
    public class Projectmodel {
        public int ID { get; set; }
        public string Description { get; set; }
        public virtual List<Document> Documents { get; set; }
        public virtual List<Phase> Phases { get; set; }

        public bool addDocument(Document Document) {
            try {
                Documents.Add(Document);
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }
        public bool removeDocument(Document Document) {
            try {
                Documents.Remove(Document);
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }
        public bool addPhase(Phase Phase) {
            try {
                Phases.Add(Phase);
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }
        public bool removePhase(Phase Phase) {
            try {
                Phases.Remove(Phase);
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }
    }
}
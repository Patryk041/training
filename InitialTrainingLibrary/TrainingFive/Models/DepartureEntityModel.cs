using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrainingFive.Models
{
    public class DepartureEntityModel
    {
        // strefa inputuu uzytkownika
        public int ClientId { get; set; }

        public int SectionId { get; set; }

        public int ConsultantId { get; set; }

        public int StatusId { get; set; }

        public int WeeksCount { get; set; }


        // --- strefa uzup[elniania formularza
        public IEnumerable<SelectListItem> ClientsList = new List<SelectListItem>
        {
            new SelectListItem() {Text = "Sito", Value = "1"},
            new SelectListItem() {Text = "Chmura", Value = "2"},
            new SelectListItem() {Text = "Emgie", Value = "3"},
            new SelectListItem() {Text = "Dysq", Value = "4"},
        };

        public Dictionary<int, IEnumerable<SelectListItem>> SectionsList = new Dictionary<int, IEnumerable<SelectListItem>>()
        {
            { 1, new List<SelectListItem>()
                 {
                     new SelectListItem() {Text = "sek 1", Value = "1"},
                     new SelectListItem() {Text = "sek 2", Value = "2"},
                     new SelectListItem() {Text = "sek 3", Value = "3"},
                     new SelectListItem() {Text = "sek 4", Value = "4"}
                 }
            },
            { 2, new List<SelectListItem>()
                 {
                     new SelectListItem() {Text = "ch sek 1", Value = "5"},
                     new SelectListItem() {Text = "ch sek 2", Value = "6"},
                     new SelectListItem() {Text = "ch sek 3", Value = "7"},
                 }
            },
            { 3, new List<SelectListItem>()
                 {
                     new SelectListItem() {Text = "mg sek 1", Value = "8"},
                     new SelectListItem() {Text = "mg sek 2", Value = "9"},
                     new SelectListItem() {Text = "mg sek 3", Value = "10"}
                 }            },
            { 4, new List<SelectListItem>()
                 {
                     new SelectListItem() {Text = "dq sek 1", Value = "11"},
                     new SelectListItem() {Text = "dq sek 2", Value = "12"},
                     new SelectListItem() {Text = "dq sek 3", Value = "13"},
                     new SelectListItem() {Text = "dq sek 4", Value = "14"},
                 }
            },
//            { 
//            { 1, 
//            new SelectListItem() {Text = "Sito", Value = "1"},
            
//            } }
        };

        public IEnumerable<SelectListItem> ConsultantsList = new List<SelectListItem>
        {
            new SelectListItem() {Text = "kukiz", Value = "1"},
            new SelectListItem() {Text = "ziobro", Value = "2"},
            new SelectListItem() {Text = "kaczynski", Value = "3"},
            new SelectListItem() {Text = "kurski", Value = "4"},
        };

        public IEnumerable<SelectListItem> StatusList = new List<SelectListItem>
        {
            new SelectListItem() {Text = "nowy", Value = "1"},
            new SelectListItem() {Text = "stary", Value = "2"},
            new SelectListItem() {Text = "sredsni", Value = "3"},
            new SelectListItem() {Text = "inny", Value = "4"},
            new SelectListItem() {Text = "bardzo inny", Value = "5"},
        };
    }
}
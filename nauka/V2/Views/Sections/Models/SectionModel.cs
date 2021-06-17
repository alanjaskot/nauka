using System;
using System.Collections.Generic;
using System.Text;
using nauka.V2.Models;
using nauka.V2.Services;
using nauka.V2.Services.Sections;

namespace nauka.V2.Views.Sections.Models
{
    public class SectionModel
    {
        private readonly SectionService _sectionService;

        public SectionModel()
        {
            // w kazdym modelu nie robic nwe cosTam 
            // tylko korzystasz z tego wczesnijeszczego magazynu 
            // dzieki tamu nie gubisz danych 
            // gdyby robisz new to tworzysz nowa instacje klasy, nowy obiekt 
            // musiz myslec jak z puszkach szyfladchach, 
            // jak nowa puszk,a to ona jest pusta, jak do jednej wkladasz to w innej nowej tego nie ma 
            // static wlasnie to ogarnia 
            // reszta juz jest prosta 

            _sectionService = ServiceManager.Sections;
        }


        /// <summary>
        /// teraz tak 
        /// w modelu ladujesz wszystko co dotyczny danyc 
        /// czyli metody add, delete, update, save itp 
        /// model reprezentuje tylko dane i odp za ich zapis
        /// 
        /// controler robi logike 
        /// laczy model i vidokiem 
        /// i obrabia zarzadzanie danychmi 
        /// podsrawa do dobry model 
        /// 
        /// vidok ma miec jak najmniej kodu, mozesz miec rozne widoku tego samego wiec najepiej jak ma malo kodu 
        /// dziel jak najwieecej na metody, get set na wartosci 
        /// staraj sie myslec prosto, programowanie jest proste, pamietaj ze za rok musz wrocic i cos poprawic :) 
        
        /// 
        /// </summary>
        public Section Section { get; set; }

        internal List<Section> GetSections()
        {
            var result = default(List<Section>);
            try
            {
                result = _sectionService.GetSections().Result;
            }
            catch
            {
                throw;
            }
         
            return result;
        }

        internal void Save()
        {
            _sectionService.AddSection(Section);
        }
    }
}

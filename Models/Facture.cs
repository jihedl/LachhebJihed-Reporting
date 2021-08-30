using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reporting.Models
{
    public class Facture
    {
        [Key]
        public int? IdFacture { get; set; }
        public string Numero { get; set; }
        public DateTime? DateEmission { get; set; }
        public DateTime? DateEcheance { get; set; }
        public decimal? Taxe { get; set; }
        public Boolean? IsTaxe { get; set; }
        public decimal? TimbreFiscale { get; set; }
        public decimal? MontantTotal { get; set; }
        public string Commentaire { get; set; }
        public string NumBonCommande { get; set; }
        public string Periode { get; set; }
        public int? IdClient { get; set; }
        public int? IdAssurance { get; set; }
        public int? Periodicite { get; set; }
        public int? TypeTaxe { get; set; }
        public int? Devise { get; set; }
        public int? Type { get; set; }
        public int? Etat { get; set; }
        public string CommercialSaisie { get; set; }
        public string CommercialValidation { get; set; }
        public DateTime? MoisFacturation { get; set; }
        public decimal? ValeurRistourne { get; set; }
        public Boolean? IsRistourne { get; set; }
        public string MoisImportBooking { get; set; }
        public int? RemiseExceptionnelle { get; set; }
        public int? NumPiece { get; set; }
        public Boolean? IsExported { get; set; }
        public int? IdClientOrigine { get; set; }
        public Boolean? EnvoiAgentValidation { get; set; }
        public Boolean? IsRetourne { get; set; }
        public DateTime? DateCreation { get; set; }
        public Boolean? FactureSms { get; set; }
        public Boolean? IsBanque { get; set; }
        public decimal? MontantPreleve { get; set; }
        public int? idPrelevement { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.DAL.models
{
    public class Personalia
    {
        [Key]
        public int PersId { get; set; }
        public int Id { get; set; }
        public User User { get; set; }
        public string lastname { get; set; }
        public string lastname_partner { get; set; }
        public string first_names { get; set; }
        public string first_names_partner { get; set; }
        public string place_birth { get; set; }
        public string place_birth_partner { get; set; }
        public DateTime dob { get; set; }
        public DateTime db_pertner { get; set; }
        public string street { get; set; }
        public string street_partner { get; set; }
        public string pobox { get; set; }
        public string pobox_partner { get; set; }
        public string city { get; set; }
        public string city_partner { get; set; }
        public string phone_home { get; set; }
        public string phone_home_partner { get; set; }
        public string mob { get; set; }
        public string mob_partner { get; set; }
        public string email { get; set; }
        public string email_partner { get; set; }
        public string bstaat { get; set; }
        public string bstaat_partner { get; set; }
        public string hgoederen { get; set; }
        public string hgoederen_partner { get; set; }
        public string reg_partnership { get; set; }
        public string living_together { get; set; }
        public string legitimatie_soort { get; set; }
        public string legitimatie_soort_partner { get; set; }
        public string legitimatie_no { get; set; }
        public string legitimatie_no_partner { get; set; }
        public string notaris { get; set; }
        public string notaris_adres { get; set; }
        public string bedrag_roerende_zaken { get; set; }
        public string partner_medekoper { get; set; }
        public string line_35 { get; set; }
        public string line_36 { get; set; }
        public string line_37 { get; set; }
        public string line_38 { get; set; }
        public string line_39 { get; set; }
        public string line_40 { get; set; }
        public string line_41 { get; set; }
        public string line_42 { get; set; }
        public string line_43 { get; set; }
        public string line_44 { get; set; }
        public string line_45 { get; set; }
        public string line_46 { get; set; }
        public string line_47 { get; set; }
        public string line_48 { get; set; }
        public string line_49 { get; set; }
        public string line_50 { get; set; }

    }
}
    
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using api.DAL.data;
using api.DAL.dtos;
using api.DAL.helpers;
using AutoMapper;
using Cardiohelp.data.Interfaces;
using Microsoft.AspNetCore.Http;

namespace api.DAL.code
{
    public class SpecialMaps
    {
        
        private IHospitalRepository _hos;
        private IHttpContextAccessor _http;
        private IMapper _map;
        private Dropdownlists _drops;
        public SpecialMaps(
        IHttpContextAccessor http, 
        IHospitalRepository hos, 
        IMapper map, 
        Dropdownlists drops)
        {
            _http = http;
            _map = map;
            _drops = drops;
            _hos = hos;
        }
        public  User mapToUserAsync(UserForUpdateDto help, User h)
        {
            h.active = help.active;
           // h.center_id = await this.saveHospitalNameAsNumber(help.center_id);
            h.contributor_id = help.contributor_id;
            h.Id = help.Id;
            h.paid_till = help.paid_till;
            h.user_role = help.user_role;
            h.username = help.username;
            return h;
        }
        public async Task<UserForReturnDto> mapToUserForReturnAsync(User help)
        {
            var h = new UserForReturnDto();
            h.active = help.active;
            h.center_id = await this.getNameOfHospitalAsync(help.center_id);
            h.contributor_id = help.contributor_id;
            h.Id = help.Id;
            h.paid_till = help.paid_till;
            h.user_role = help.user_role;
            h.username = help.username;
            return h;
        } 
        // public UserForReturnDto mapToUserForReturn(User help){ return _map.Map<User, UserForReturnDto>(help);}
        public List<CardioForReturn> mapToListOfmessageToReturnFromListOfMessageAsync(PagedList<Cardio> messagesFromRepo)
        {
            var help = new List<CardioForReturn>();
            foreach (Cardio c in messagesFromRepo)
            {
                var d = new CardioForReturn();
                d.Id = c.Id;
                d.center_id = c.center_id;
                d.cassette_id = c.cassette_id;
                d.contributor_id = c.contributor_id;
                d.indication = getIndication(c.indication);
                d.patient_age = c.patient_age;
                d.patient_gender = c.patient_gender;
                d.registry_id = c.registry_id;
                d.support_mode = c.support_mode;
                d.time_supported = c.time_supported;
                help.Add(d);
            }
            return help;
        }
        public CardioDetailsDTO mapToCardioDetails(Cardio c)
        {
            var help = new CardioDetailsDTO();
            help = _map.Map<Cardio, CardioDetailsDTO>(c);
            return help;
        }
        public Cardio mapToCardio(CardioDetailsDTO ctd, Cardio c)
        {
            return _map.Map<CardioDetailsDTO, Cardio>(ctd, c);
        }
        public hospital mapToHospitalAsync(hospitalForUpdateDTO td, hospital hospital_before){
          return _map.Map<hospitalForUpdateDTO, hospital>(td,hospital_before);
        }
        public HemoForReturnDTO mapToHemoForReturn(Cardio c){
            return _map.Map<Cardio, HemoForReturnDTO>(c);
        }
        public int getCurrentUserId()
        {
            var userId = _http.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return Convert.ToInt32(userId);
        }
        private string getIndication(int indication)
        {
            var help = "";
            var ret = new List<Class_Item>();
            ret = _drops.getReasonForUse();
            help = ret.Find(x => x.value == indication).description;
            return help;
        }
        private async Task<string> getNameOfHospitalAsync(string center_id){
            
             if(String.IsNullOrEmpty(center_id)){return "Choose";}
             else{
             var help = Convert.ToInt32(center_id);
             var selectedHospital = await _hos.getHospitalDetails(help);
             return selectedHospital.name;}
        }
    }

}
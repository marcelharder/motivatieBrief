using System;

namespace api.DAL.dtos
{
    public class HemoForReturnDTO
    {
        public int Id { get; set; }
        public string center_id { get; set; }
        public int registry_id { get; set; }
        public byte[] hemodynamics { get; set; }
    }
}
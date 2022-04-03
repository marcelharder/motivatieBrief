using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cardios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    center_id = table.Column<string>(type: "TEXT", nullable: true),
                    registry_id = table.Column<int>(type: "INTEGER", nullable: false),
                    cassette_id = table.Column<string>(type: "TEXT", nullable: true),
                    hemodynamics = table.Column<byte[]>(type: "BLOB", nullable: true),
                    contributor_id = table.Column<string>(type: "TEXT", nullable: true),
                    patient_age = table.Column<int>(type: "INTEGER", nullable: false),
                    patient_gender = table.Column<int>(type: "INTEGER", nullable: false),
                    indication = table.Column<int>(type: "INTEGER", nullable: false),
                    support_mode = table.Column<int>(type: "INTEGER", nullable: false),
                    time_supported = table.Column<int>(type: "INTEGER", nullable: false),
                    comment1 = table.Column<string>(type: "TEXT", nullable: true),
                    comment2 = table.Column<string>(type: "TEXT", nullable: true),
                    comment3 = table.Column<string>(type: "TEXT", nullable: true),
                    comment4 = table.Column<string>(type: "TEXT", nullable: true),
                    comment5 = table.Column<string>(type: "TEXT", nullable: true),
                    page_1_complete = table.Column<bool>(type: "INTEGER", nullable: false),
                    page_2_complete = table.Column<bool>(type: "INTEGER", nullable: false),
                    page_3_complete = table.Column<bool>(type: "INTEGER", nullable: false),
                    page_4_complete = table.Column<bool>(type: "INTEGER", nullable: false),
                    page_5_complete = table.Column<bool>(type: "INTEGER", nullable: false),
                    support_mode_other = table.Column<string>(type: "TEXT", nullable: true),
                    selected_cannulation_site_1 = table.Column<int>(type: "INTEGER", nullable: false),
                    selected_cannulation_site_2 = table.Column<int>(type: "INTEGER", nullable: false),
                    selected_cannulation_site_3 = table.Column<int>(type: "INTEGER", nullable: false),
                    selected_size_1 = table.Column<int>(type: "INTEGER", nullable: false),
                    selected_size_2 = table.Column<int>(type: "INTEGER", nullable: false),
                    selected_size_3 = table.Column<int>(type: "INTEGER", nullable: false),
                    selected_length_1 = table.Column<int>(type: "INTEGER", nullable: false),
                    selected_length_2 = table.Column<int>(type: "INTEGER", nullable: false),
                    selected_length_3 = table.Column<int>(type: "INTEGER", nullable: false),
                    selected_vv_size = table.Column<int>(type: "INTEGER", nullable: false),
                    percutaneous_1 = table.Column<bool>(type: "INTEGER", nullable: false),
                    percutaneous_2 = table.Column<bool>(type: "INTEGER", nullable: false),
                    percutaneous_3 = table.Column<bool>(type: "INTEGER", nullable: false),
                    double_lumen = table.Column<bool>(type: "INTEGER", nullable: false),
                    selected_age = table.Column<int>(type: "INTEGER", nullable: false),
                    selected_weight = table.Column<double>(type: "REAL", nullable: true),
                    selected_height = table.Column<double>(type: "REAL", nullable: true),
                    selected_fac = table.Column<int>(type: "INTEGER", nullable: false),
                    selected_intubated = table.Column<int>(type: "INTEGER", nullable: false),
                    selected_arrest = table.Column<int>(type: "INTEGER", nullable: false),
                    selected_btt = table.Column<int>(type: "INTEGER", nullable: false),
                    ox_failure = table.Column<bool>(type: "INTEGER", nullable: false),
                    tub_rupture = table.Column<bool>(type: "INTEGER", nullable: false),
                    pump_malf = table.Column<bool>(type: "INTEGER", nullable: false),
                    heat_malf = table.Column<bool>(type: "INTEGER", nullable: false),
                    clots = table.Column<bool>(type: "INTEGER", nullable: false),
                    air_circuit = table.Column<bool>(type: "INTEGER", nullable: false),
                    conn_crack = table.Column<bool>(type: "INTEGER", nullable: false),
                    cannula_problems = table.Column<bool>(type: "INTEGER", nullable: false),
                    hemo = table.Column<bool>(type: "INTEGER", nullable: false),
                    hemo_gi = table.Column<bool>(type: "INTEGER", nullable: false),
                    hemo_ca = table.Column<bool>(type: "INTEGER", nullable: false),
                    hemo_su = table.Column<bool>(type: "INTEGER", nullable: false),
                    hemo_he = table.Column<bool>(type: "INTEGER", nullable: false),
                    hemo_di = table.Column<bool>(type: "INTEGER", nullable: false),
                    neuro = table.Column<bool>(type: "INTEGER", nullable: false),
                    neuro_br = table.Column<bool>(type: "INTEGER", nullable: false),
                    neuro_se = table.Column<bool>(type: "INTEGER", nullable: false),
                    neuro_ee = table.Column<bool>(type: "INTEGER", nullable: false),
                    neuro_in = table.Column<bool>(type: "INTEGER", nullable: false),
                    neuro_he = table.Column<bool>(type: "INTEGER", nullable: false),
                    renal = table.Column<bool>(type: "INTEGER", nullable: false),
                    renal_cr_1 = table.Column<bool>(type: "INTEGER", nullable: false),
                    renal_cr_2 = table.Column<bool>(type: "INTEGER", nullable: false),
                    renal_di = table.Column<bool>(type: "INTEGER", nullable: false),
                    renal_he = table.Column<bool>(type: "INTEGER", nullable: false),
                    renal_ca = table.Column<bool>(type: "INTEGER", nullable: false),
                    pulm = table.Column<bool>(type: "INTEGER", nullable: false),
                    pulm_pn = table.Column<bool>(type: "INTEGER", nullable: false),
                    pulm_pu = table.Column<bool>(type: "INTEGER", nullable: false),
                    cp = table.Column<bool>(type: "INTEGER", nullable: false),
                    cp_in = table.Column<bool>(type: "INTEGER", nullable: false),
                    cp_my = table.Column<bool>(type: "INTEGER", nullable: false),
                    cp_hy = table.Column<bool>(type: "INTEGER", nullable: false),
                    cp_pda_1 = table.Column<bool>(type: "INTEGER", nullable: false),
                    cp_ta_1 = table.Column<bool>(type: "INTEGER", nullable: false),
                    cp_pda_2 = table.Column<bool>(type: "INTEGER", nullable: false),
                    cp_ta_2 = table.Column<bool>(type: "INTEGER", nullable: false),
                    cp_cp = table.Column<bool>(type: "INTEGER", nullable: false),
                    cp_ca = table.Column<bool>(type: "INTEGER", nullable: false),
                    cp_pda_3 = table.Column<bool>(type: "INTEGER", nullable: false),
                    cp_pda_4 = table.Column<bool>(type: "INTEGER", nullable: false),
                    cp_ta_3 = table.Column<bool>(type: "INTEGER", nullable: false),
                    infect = table.Column<bool>(type: "INTEGER", nullable: false),
                    infect_cu = table.Column<bool>(type: "INTEGER", nullable: false),
                    infect_wb = table.Column<bool>(type: "INTEGER", nullable: false),
                    meta = table.Column<bool>(type: "INTEGER", nullable: false),
                    meta_gl_1 = table.Column<bool>(type: "INTEGER", nullable: false),
                    meta_gl_2 = table.Column<bool>(type: "INTEGER", nullable: false),
                    meta_ph_1 = table.Column<bool>(type: "INTEGER", nullable: false),
                    meta_ph_2 = table.Column<bool>(type: "INTEGER", nullable: false),
                    meta_hy = table.Column<bool>(type: "INTEGER", nullable: false),
                    selected_reason_death = table.Column<int>(type: "INTEGER", nullable: false),
                    selected_reason = table.Column<int>(type: "INTEGER", nullable: false),
                    reason_cns = table.Column<string>(type: "TEXT", nullable: true),
                    reason_pulmonary = table.Column<string>(type: "TEXT", nullable: true),
                    reason_cardiac = table.Column<string>(type: "TEXT", nullable: true),
                    reason_liver = table.Column<string>(type: "TEXT", nullable: true),
                    reason_infection = table.Column<string>(type: "TEXT", nullable: true),
                    reason_other = table.Column<string>(type: "TEXT", nullable: true),
                    selected_repair = table.Column<int>(type: "INTEGER", nullable: false),
                    discharged_alive = table.Column<bool>(type: "INTEGER", nullable: false),
                    selected_discharge_location = table.Column<int>(type: "INTEGER", nullable: false),
                    discharge = table.Column<DateTime>(type: "TEXT", nullable: false),
                    extubation = table.Column<DateTime>(type: "TEXT", nullable: false),
                    death_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    discharge_hours = table.Column<int>(type: "INTEGER", nullable: false),
                    extubation_hours = table.Column<int>(type: "INTEGER", nullable: false),
                    death_date_hours = table.Column<int>(type: "INTEGER", nullable: false),
                    discharge_minutes = table.Column<int>(type: "INTEGER", nullable: false),
                    extubation_minutes = table.Column<int>(type: "INTEGER", nullable: false),
                    death_date_minutes = table.Column<int>(type: "INTEGER", nullable: false),
                    start = table.Column<DateTime>(type: "TEXT", nullable: false),
                    start_hour = table.Column<int>(type: "INTEGER", nullable: false),
                    start_min = table.Column<int>(type: "INTEGER", nullable: false),
                    stop = table.Column<DateTime>(type: "TEXT", nullable: false),
                    stop_hour = table.Column<int>(type: "INTEGER", nullable: false),
                    stop_min = table.Column<int>(type: "INTEGER", nullable: false),
                    date_death_followup = table.Column<DateTime>(type: "TEXT", nullable: false),
                    one_year_followup = table.Column<int>(type: "INTEGER", nullable: false),
                    last_followup = table.Column<DateTime>(type: "TEXT", nullable: false),
                    lldp = table.Column<int>(type: "INTEGER", nullable: false),
                    lldp_diam = table.Column<int>(type: "INTEGER", nullable: false),
                    lldp_length = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cardios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    center_id = table.Column<int>(type: "INTEGER", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    address = table.Column<string>(type: "TEXT", nullable: true),
                    street = table.Column<string>(type: "TEXT", nullable: true),
                    city = table.Column<string>(type: "TEXT", nullable: true),
                    pobox = table.Column<string>(type: "TEXT", nullable: true),
                    tel = table.Column<string>(type: "TEXT", nullable: true),
                    fax = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    country = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    deployed_url = table.Column<string>(type: "TEXT", nullable: true),
                    paid_till = table.Column<DateTime>(type: "TEXT", nullable: false),
                    created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    username = table.Column<string>(type: "TEXT", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "BLOB", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "BLOB", nullable: true),
                    user_role = table.Column<string>(type: "TEXT", nullable: true),
                    active = table.Column<string>(type: "TEXT", nullable: true),
                    contributor_id = table.Column<string>(type: "TEXT", nullable: true),
                    center_id = table.Column<string>(type: "TEXT", nullable: true),
                    photoUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cardios");

            migrationBuilder.DropTable(
                name: "Hospitals");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

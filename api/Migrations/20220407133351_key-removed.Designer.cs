﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.DAL;

namespace api.Migrations
{
    [DbContext(typeof(dataContext))]
    [Migration("20220407133351_key-removed")]
    partial class keyremoved
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("api.DAL.models.Brief", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("line_1")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_10")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_11")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_12")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_13")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_14")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_15")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_16")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_17")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_18")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_19")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_2")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_20")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_21")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_22")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_23")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_24")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_25")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_26")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_27")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_28")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_29")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_3")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_30")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_31")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_32")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_33")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_34")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_35")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_36")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_37")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_38")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_39")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_4")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_40")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_41")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_42")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_43")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_44")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_45")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_46")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_47")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_48")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_49")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_5")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_50")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_6")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_7")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_8")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_9")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Briefs");
                });

            modelBuilder.Entity("api.DAL.models.Cardio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("air_circuit")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("cannula_problems")
                        .HasColumnType("INTEGER");

                    b.Property<string>("cassette_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("center_id")
                        .HasColumnType("TEXT");

                    b.Property<bool>("clots")
                        .HasColumnType("INTEGER");

                    b.Property<string>("comment1")
                        .HasColumnType("TEXT");

                    b.Property<string>("comment2")
                        .HasColumnType("TEXT");

                    b.Property<string>("comment3")
                        .HasColumnType("TEXT");

                    b.Property<string>("comment4")
                        .HasColumnType("TEXT");

                    b.Property<string>("comment5")
                        .HasColumnType("TEXT");

                    b.Property<bool>("conn_crack")
                        .HasColumnType("INTEGER");

                    b.Property<string>("contributor_id")
                        .HasColumnType("TEXT");

                    b.Property<bool>("cp")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("cp_ca")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("cp_cp")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("cp_hy")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("cp_in")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("cp_my")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("cp_pda_1")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("cp_pda_2")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("cp_pda_3")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("cp_pda_4")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("cp_ta_1")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("cp_ta_2")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("cp_ta_3")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("date_death_followup")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("death_date")
                        .HasColumnType("TEXT");

                    b.Property<int>("death_date_hours")
                        .HasColumnType("INTEGER");

                    b.Property<int>("death_date_minutes")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("discharge")
                        .HasColumnType("TEXT");

                    b.Property<int>("discharge_hours")
                        .HasColumnType("INTEGER");

                    b.Property<int>("discharge_minutes")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("discharged_alive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("double_lumen")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("extubation")
                        .HasColumnType("TEXT");

                    b.Property<int>("extubation_hours")
                        .HasColumnType("INTEGER");

                    b.Property<int>("extubation_minutes")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("heat_malf")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("hemo")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("hemo_ca")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("hemo_di")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("hemo_gi")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("hemo_he")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("hemo_su")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("hemodynamics")
                        .HasColumnType("BLOB");

                    b.Property<int>("indication")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("infect")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("infect_cu")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("infect_wb")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("last_followup")
                        .HasColumnType("TEXT");

                    b.Property<int>("lldp")
                        .HasColumnType("INTEGER");

                    b.Property<int>("lldp_diam")
                        .HasColumnType("INTEGER");

                    b.Property<int>("lldp_length")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("meta")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("meta_gl_1")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("meta_gl_2")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("meta_hy")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("meta_ph_1")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("meta_ph_2")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("neuro")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("neuro_br")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("neuro_ee")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("neuro_he")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("neuro_in")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("neuro_se")
                        .HasColumnType("INTEGER");

                    b.Property<int>("one_year_followup")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ox_failure")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("page_1_complete")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("page_2_complete")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("page_3_complete")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("page_4_complete")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("page_5_complete")
                        .HasColumnType("INTEGER");

                    b.Property<int>("patient_age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("patient_gender")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("percutaneous_1")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("percutaneous_2")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("percutaneous_3")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("pulm")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("pulm_pn")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("pulm_pu")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("pump_malf")
                        .HasColumnType("INTEGER");

                    b.Property<string>("reason_cardiac")
                        .HasColumnType("TEXT");

                    b.Property<string>("reason_cns")
                        .HasColumnType("TEXT");

                    b.Property<string>("reason_infection")
                        .HasColumnType("TEXT");

                    b.Property<string>("reason_liver")
                        .HasColumnType("TEXT");

                    b.Property<string>("reason_other")
                        .HasColumnType("TEXT");

                    b.Property<string>("reason_pulmonary")
                        .HasColumnType("TEXT");

                    b.Property<int>("registry_id")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("renal")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("renal_ca")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("renal_cr_1")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("renal_cr_2")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("renal_di")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("renal_he")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selected_age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selected_arrest")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selected_btt")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selected_cannulation_site_1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selected_cannulation_site_2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selected_cannulation_site_3")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selected_discharge_location")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selected_fac")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("selected_height")
                        .HasColumnType("REAL");

                    b.Property<int>("selected_intubated")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selected_length_1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selected_length_2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selected_length_3")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selected_reason")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selected_reason_death")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selected_repair")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selected_size_1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selected_size_2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selected_size_3")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selected_vv_size")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("selected_weight")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("start")
                        .HasColumnType("TEXT");

                    b.Property<int>("start_hour")
                        .HasColumnType("INTEGER");

                    b.Property<int>("start_min")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("stop")
                        .HasColumnType("TEXT");

                    b.Property<int>("stop_hour")
                        .HasColumnType("INTEGER");

                    b.Property<int>("stop_min")
                        .HasColumnType("INTEGER");

                    b.Property<int>("support_mode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("support_mode_other")
                        .HasColumnType("TEXT");

                    b.Property<int>("time_supported")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("tub_rupture")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cardios");
                });

            modelBuilder.Entity("api.DAL.models.Personalia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PersId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("bedrag_roerende_zaken")
                        .HasColumnType("TEXT");

                    b.Property<string>("bstaat")
                        .HasColumnType("TEXT");

                    b.Property<string>("bstaat_partner")
                        .HasColumnType("TEXT");

                    b.Property<string>("city")
                        .HasColumnType("TEXT");

                    b.Property<string>("city_partner")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("db_pertner")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("dob")
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("email_partner")
                        .HasColumnType("TEXT");

                    b.Property<string>("first_names")
                        .HasColumnType("TEXT");

                    b.Property<string>("first_names_partner")
                        .HasColumnType("TEXT");

                    b.Property<string>("hgoederen")
                        .HasColumnType("TEXT");

                    b.Property<string>("hgoederen_partner")
                        .HasColumnType("TEXT");

                    b.Property<string>("lastname")
                        .HasColumnType("TEXT");

                    b.Property<string>("lastname_partner")
                        .HasColumnType("TEXT");

                    b.Property<string>("legitimatie_no")
                        .HasColumnType("TEXT");

                    b.Property<string>("legitimatie_no_partner")
                        .HasColumnType("TEXT");

                    b.Property<string>("legitimatie_soort")
                        .HasColumnType("TEXT");

                    b.Property<string>("legitimatie_soort_partner")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_35")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_36")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_37")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_38")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_39")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_40")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_41")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_42")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_43")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_44")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_45")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_46")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_47")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_48")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_49")
                        .HasColumnType("TEXT");

                    b.Property<string>("line_50")
                        .HasColumnType("TEXT");

                    b.Property<string>("living_together")
                        .HasColumnType("TEXT");

                    b.Property<string>("mob")
                        .HasColumnType("TEXT");

                    b.Property<string>("mob_partner")
                        .HasColumnType("TEXT");

                    b.Property<string>("notaris")
                        .HasColumnType("TEXT");

                    b.Property<string>("notaris_adres")
                        .HasColumnType("TEXT");

                    b.Property<string>("partner_medekoper")
                        .HasColumnType("TEXT");

                    b.Property<string>("phone_home")
                        .HasColumnType("TEXT");

                    b.Property<string>("phone_home_partner")
                        .HasColumnType("TEXT");

                    b.Property<string>("place_birth")
                        .HasColumnType("TEXT");

                    b.Property<string>("place_birth_partner")
                        .HasColumnType("TEXT");

                    b.Property<string>("pobox")
                        .HasColumnType("TEXT");

                    b.Property<string>("pobox_partner")
                        .HasColumnType("TEXT");

                    b.Property<string>("reg_partnership")
                        .HasColumnType("TEXT");

                    b.Property<string>("street")
                        .HasColumnType("TEXT");

                    b.Property<string>("street_partner")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("api.DAL.models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("active")
                        .HasColumnType("TEXT");

                    b.Property<string>("center_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("contributor_id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("created")
                        .HasColumnType("TEXT");

                    b.Property<string>("deployed_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("paid_till")
                        .HasColumnType("TEXT");

                    b.Property<string>("photoUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("user_role")
                        .HasColumnType("TEXT");

                    b.Property<string>("username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("api.DAL.models.hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("address")
                        .HasColumnType("TEXT");

                    b.Property<int>("center_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("city")
                        .HasColumnType("TEXT");

                    b.Property<string>("country")
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("fax")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("pobox")
                        .HasColumnType("TEXT");

                    b.Property<string>("street")
                        .HasColumnType("TEXT");

                    b.Property<string>("tel")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("api.DAL.models.Brief", b =>
                {
                    b.HasOne("api.DAL.models.User", "User")
                        .WithMany("briefs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("api.DAL.models.Personalia", b =>
                {
                    b.HasOne("api.DAL.models.User", "User")
                        .WithMany("pers")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("api.DAL.models.User", b =>
                {
                    b.Navigation("briefs");

                    b.Navigation("pers");
                });
#pragma warning restore 612, 618
        }
    }
}

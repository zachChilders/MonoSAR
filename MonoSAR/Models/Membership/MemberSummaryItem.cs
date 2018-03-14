﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonoSAR.Models.Membership
{
    public class MemberSummaryItem
    {

        public MemberSummaryItem(Models.DB.Member dataEntity)
        {
            this.First = dataEntity.FirstName;
            this.Last = dataEntity.LastName;
            this.HamCallSign = dataEntity.Ham;
            this.Joined = dataEntity.Joined;
            this.PhoneCell = dataEntity.PhoneCell;
            this.PhoneHome = dataEntity.PhoneHome;
            this.PhoneWork = dataEntity.PhoneWork;
            this.State = dataEntity.State;
            this.ZIP = dataEntity.Zipcode;
        }





        public String First { get; set; }
        public String Last { get; set; }
        public String HamCallSign { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String ZIP { get; set; }
        public String Email { get; set; }
        public DateTime Joined { get; set; }
        public String PhoneHome { get; set; }
        public String PhoneCell { get; set; }
        public String PhoneWork { get; set; }
        public String Capacity { get; set; }

        public DateTime MedicalExpires { get; set; }
        public Boolean IsMedicalExpired {

        get {
                if (MedicalExpires > DateTime.Now)
                { return false; }

                return true;
            }
                                        }
        public DateTime CPRExpires { get; set; }
        public Boolean IsCPRExpired
        {

            get
            {
                if (CPRExpires > DateTime.Now)
                { return false; }

                return true;
            }
        }
        public DateTime BeaconExpires { get; set; }
        public Boolean IsBeaconExpired
        {

            get
            {
                if (BeaconExpires > DateTime.Now)
                { return false; }

                return true;
            }
        }
        public Boolean IsWinterFieldReady
        {
            get
            {
                if (!IsMedicalExpired && !IsCPRExpired && !IsBeaconExpired)
                { return true; }
                else
                { return false; }
            }
        }
        public Boolean IsSummerFieldReady
        {
            get
            {
                if (!IsMedicalExpired && !IsCPRExpired)
                { return true; }
                else
                { return false; }
            }
        }

        public Boolean IsICS100 { get; set; }
        public Boolean IsICS200 { get; set; }
        public Boolean IsBuildingVehicleTested { get; set; }
        public Boolean IsPackChecked { get; set; }

    }
}

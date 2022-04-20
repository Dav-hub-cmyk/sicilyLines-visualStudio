﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicilylines
{
    class Tarifer
    {
        private int id;
        private int id_liaison;
        private int period_id;
        private int type_id;
        private double tarif;

        public Tarifer()
        {

        }
        public Tarifer(int idTa, int idLi, int per_id, int ty_id, double tar)
        {
            this.id = idTa;
            this.id_liaison = idLi;
            this.period_id = per_id;
            this.type_id = ty_id;
            this.tarif = tar;
        }

        public int id_tarifer
        {
            get { return this.id; }

        }

        public int id_liaison_tar
        {
            get { return this.id_liaison; }

        }
        public int id_perdiode
        {
            get { return this.period_id; }

        }
        public int id_type
        {
            get { return this.type_id; }

        }
        public double Tarif
        {
            get { return this.tarif; }

        }
    }
}

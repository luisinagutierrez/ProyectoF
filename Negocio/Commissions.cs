﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Commissions
    {
        public List<Entidades.Commissions> GetAll()
        {
            Datos.Commissions ds;
            try
            {
                ds = new Datos.Commissions();
                return ds.GetAll();
            }
            finally
            {
                ds = null;
            }
        }

        public void Add(int idP, string descrip, int year)
        {
            Datos.Commissions ds;
            try
            {
                ds = new Datos.Commissions();
                ds.Add(idP, descrip, year);
            }
            finally
            {
                ds = null;
            }
        }

        public void Update(int idC, string descrip, int y, int idP)
        {
            Datos.Commissions ds;
            try
            {
                ds = new Datos.Commissions();
                ds.Update(idC, descrip, y, idP);
            }
            finally
            {
                ds = null;
            }
        }

        public int UpdateCommission(int idC, string descrip, int y, int idP)
        {
            Datos.Commissions ds;
            try
            {
                Entidades.Commissions com = new Entidades.Commissions();
                ds = new Datos.Commissions();
                com = ds.GetOne(idC);
                if (com != null)
                {
                    this.Update(idC, descrip, y, idP);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            finally
            {
                ds = null;
            }
        }

        public void Delete(int id)
        {
            Datos.Commissions ds;
            try
            {
                Entidades.Commissions com = new Entidades.Commissions();
                ds = new Datos.Commissions();
                com = ds.GetOne(id);
                if (com != null)
                {
                    ds.Delete(id);
                }
                else
                {
                    throw new Exception("No se puede eliminar la comision, ya que no existe");
                }
            }
            finally
            {
                ds = null;
            }
        }

    }
}

﻿using Datos;
using Entidades;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Users
    {
        public int ValidateUser(string userName, string password)
        {
            Datos.Users ds;
            try
            {
                ds = new Datos.Users();
                int privilege = ds.GetPrivilege(userName, password);
                return privilege;
            }
            finally
            {
                ds = null;
            }
        }
        public List<Entidades.Users> GetAll()
        {
            Datos.Users ds;
            try
            {
                ds = new Datos.Users();
                return ds.GetAll();
            }
            finally
            {
                ds = null;
            }
        }
        public Entidades.Users GetOne(int ID)
        {
            Datos.Users ds;
            try
            {
                ds = new Datos.Users();
                Entidades.Users user = ds.GetOne(ID);

                return user;
            }
            finally
            {
                ds = null;
            }

        }
        public int GetIdPerson(string nom, string pass)
        {
            Datos.Users ds;
            try
            {
                ds = new Datos.Users();
                int IdPerson = ds.GetIdPerson(nom, pass);
                return IdPerson;
            }
            finally
            {
                ds = null;
            }
        }
        public int GetUserByIdPerson(int idP)
        {
            Datos.Users ds;
            try
            {
                ds = new Datos.Users();
                Entidades.Users user = ds.GetUserByIdPerson(idP);
                return user.IdUser;
            }
            finally
            {
                ds = null;
            }
        }

        public int ChangePassword(string username,int id, string pass)
        {
            Datos.Users ds;
            try
            {
                ds = new Datos.Users();
                Entidades.Users user = ds.GetUserByUserName(username, id);
                if (user.IdUser != 0) 
                {
                    ds.ChangePassword(username, pass);
                }
                return user.IdUser;

            }
            finally
            {
                ds = null;
            }
        }
        public void Delete(int ID)
        {
            Datos.Users ds;
            try
            {
                ds = new Datos.Users();
                ds.Delete(ID);
            }
            finally
            {
                ds = null;
            }

        }
        public void Add(int idP, int privilege, string name, string pass)
        {
            Datos.Users ds;
            try
            {
                ds = new Datos.Users();
                ds.Add(idP, privilege, name, pass);
            }
            finally
            {
                ds = null;
            }

        }
        public void Update(Entidades.Users item)
        {
            Datos.Users ds;
            try
            {
                ds = new Datos.Users();
                int id = item.IdUser;
                ds.Update(item, id);
            }
            finally
            {
                ds = null;
            }
        }

        public int UpdateUser(int idUser,string userName,string password,bool status,bool changePassword,int idPerson,int privilege)
        {
            Datos.Users ds;
            try
            {
                Entidades.Users u = new Entidades.Users();
                ds = new Datos.Users();
                u = ds.GetOne(idUser);
                if (u.IdUser != 0)
                {
                    u.IdUser = idUser;
                    u.UserName = userName;
                    u.Password = password;
                    u.Status = status;
                    u.ChangePassword = changePassword;
                    u.IdPerson = idPerson;
                    u.Privilege = privilege;
                    Update(u);
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



        //public void Save(Entidades.Users usuario)
        //{
        //    if (usuario.St == Entity.States.Delete)
        //    {
        //        this.Delete(usuario.ID);
        //    }
        //    else if (usuario.St == Entity.States.New)
        //    {
        //        this.Add(usuario);
        //    }
        //    else if (usuario.St == Entity.States.Update)
        //    {
        //        this.Update(usuario);
        //    }
        //}

    }
}

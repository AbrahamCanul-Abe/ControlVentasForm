using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Services;
using System.Web.Security;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SOLTUM.Satelites.ControlDeCasas.Account
{
    public partial class Login : System.Web.UI.Page
    {
        #region Properties
        public static string MessegeOnInit
        {
            get
            {
                if (HttpContext.Current.Session["MessegeOnInit"] != null)
                    return HttpContext.Current.Session["MessegeOnInit"].ToString();
                else
                    return string.Empty;
            }

            set
            {
                HttpContext.Current.Session["MessegeOnInit"] = value;
            }
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            if (HttpContext.Current.Session["LoginUser"] != null)
            {
                //Class.Security.Bitacora.BitacoraLogout();
                HttpContext.Current.Session.Clear();
            }
        }
        protected void Login_Authenticate(object sender, AuthenticateEventArgs e)
        {
            //Boolean blnresult;
            //blnresult = false;

            //// Pass UserName  and Password from login1 control to an authentication function which will check will check the user name and password from sql server.
            //// Then will retrun a true or false value into blnresult variable
            //blnresult = Authentication(Login.UserName, Login.Password);

            //// If blnresult has a true value then authenticate user 
            //if (blnresult == true)
            //{
            //    // This is the actual statement which will authenticate the user
            //    e.Authenticated = true;
            //    // Store your authentication mode in session variable 
            //    Session["Check"] = true;
            //}
            //else
            //    // If user faild to provide valid user name and password
            //    e.Authenticated = false;
        }

        #region WebMethod
        [WebMethod]
        [ScriptMethod(UseHttpGet = false)]
        public static Response Authentication(string user, string pass)
        {
            return autentication(user, pass, 0);
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = false)]
        public static Response Authentication(string user, string pass, string level)
        {
            int SessionLevel = 0;
            try
            {
                SessionLevel = int.Parse(level);
            }
            catch (Exception)
            {
                SessionLevel = 0;
            }
            return autentication(user, pass, SessionLevel);
        }
        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false)]
        //public static Response MailChangePass(string email)
        //{
        //    Response response = new Response();
        //    try
        //    {
        //        if (!Class.Security.Validations.ValidarEmailInternos(email))
        //        {
        //            response.Status = System.Net.HttpStatusCode.BadRequest;
        //            response.Message = "Ingrese un correo electronico Válido";
        //            return response;
        //        }
        //        List<UserEntityObject> users = new UserBusinessObject().GetUserEntitiesbyEmailUser(email);
        //        if (users.Count <= 0)
        //        {
        //            response.Status = System.Net.HttpStatusCode.BadRequest;
        //            response.Message = "No se encontraron coinccidencias con los datos proporcionados";
        //            return response;
        //        }
        //        else
        //        {
        //            ResetPasswordBusinessObject resetBusiness = new ResetPasswordBusinessObject();
        //            users[0].Email = email;
        //            int result = resetBusiness.CreateSendTokenEmail(users[0], ResetPasswordEntityObject.TypeSendEmail.Reset);
        //            if (result > 0)
        //            {
        //                response.Status = System.Net.HttpStatusCode.OK;
        //                response.Message = "La solicitud de recuperación de contraseña ha sido enviada a su correo electrónico";
        //            }
        //            else
        //            {
        //                response.Status = System.Net.HttpStatusCode.InternalServerError;
        //                response.Message = "No se pudo enviar el correo, intente mas tarde.";
        //            }
        //            return response;
        //        }
        //        //response.Status = System.Net.HttpStatusCode.InternalServerError;
        //        //response.Message = "Existen ambiguedad en usuarios, contacte con el administrador de sistema";
        //        //response.ErrorMessage = "Existen dos o mas usuarios con los mismos datos de Email y/o Usuario";
        //    }
        //    catch (Exception ex)
        //    {
        //        response.Status = System.Net.HttpStatusCode.InternalServerError;
        //        response.Message = "Ha ocurrido un error. Por favor contacte con el administrador";
        //        response.ErrorMessage = ex.Message;
        //        throw;
        //    }
        //    return response;
        //}

        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false)]
        //public static Response ChangePass(string CurrentPass, string NewPass, string NewPassR)
        //{
        //    CurrentPass = Class.Security.Validations.ValidateInput(CurrentPass);
        //    NewPassR = Class.Security.Validations.ValidateInput(NewPassR);
        //    Response response = new Response();
        //    try
        //    {
        //        if (string.IsNullOrEmpty(CurrentPass) && string.IsNullOrEmpty(NewPass) && string.IsNullOrEmpty(NewPassR))
        //        {
        //            response.Status = System.Net.HttpStatusCode.BadRequest;
        //            response.Message = "Faltan campos por llenar";
        //            return response;
        //        }

        //        if (!Class.Security.Validations.ValidarContraseña(NewPass))
        //        {
        //            response.Status = System.Net.HttpStatusCode.NotAcceptable;
        //            response.Message = "La contraseña debe ser de 8 a 16 caracteres, no debe tener espacios, debe tener al menos: un numero, una letra en mayuscula y una en minuscula, un simbolo (@#$%^&+=)";
        //            return response;
        //            //throw new Exception("La contraseña debe ser de 8 a 16 caracteres, no debe tener espacios, debe tener al menos: un numero, una letra en mayuscula y una en minuscula, un simbolo (@#$%^&+=)");
        //        }

        //        UserEntityObject Login = (UserEntityObject)HttpContext.Current.Session["LoginUser"];
        //        if (!string.Equals(NewPass, NewPassR))
        //        {
        //            response.Status = System.Net.HttpStatusCode.BadRequest;
        //            response.Message = "La contraseña no coincide con la contraseña de cofirmación";
        //            return response;
        //        }

        //        if (Login.Password == CurrentPass)
        //        {
        //            UserBusinessObject userBusiness = new UserBusinessObject();
        //            if (Login.Access == UserEntityObject.LevelAccess.Administrador || Login.Access == UserEntityObject.LevelAccess.Operativo)
        //            {
        //                Login.Password = NewPassR;
        //                userBusiness.Save(Login);
        //            }
        //            else
        //            {
        //                userBusiness.SetPasswordAllPorfiles(Login.UserName, NewPass);
        //            }

        //            response.Message = "La contraseña ha sido cambiada";
        //            return response;
        //        }

        //        response.Status = System.Net.HttpStatusCode.BadRequest;
        //        response.Message = "La contraseña actual proporcionada no es correcta";
        //    }
        //    catch (Exception ex)
        //    {
        //        response.Status = System.Net.HttpStatusCode.InternalServerError;
        //        response.Message = "Ocurrio un error inesperado, Contacte con el administrador";
        //        response.ErrorMessage = ex.Message;
        //    }

        //    return response;
        //}

        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false)]
        //public static Response GetNotifycations()
        //{
        //    Response response = new Response();
        //    List<NotificationEntityObject> notificaciones = new List<NotificationEntityObject>();
        //    NotificationEntityObject notification = new NotificationEntityObject
        //    {
        //        Id = 1,
        //        Title = "Sin Notificaciones",
        //        Time = "",
        //        Body = "",
        //        Footer = ""
        //    };
        //    response.Data = notificaciones;
        //    return response;
        //}

        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false)]
        //public static Response VerifyNotifications()
        //{
        //    Response response = new Response
        //    {
        //        Data = true
        //    };
        //    return response;
        //}

        [WebMethod]
        [ScriptMethod(UseHttpGet = false)]
        public static Response SetLocation(string Latitude, string Longitude)
        {
            Response response = new Response();
            try
            {
                //Class.Security.Bitacora.SetLocation($"{Latitude},{Longitude}");
            }
            catch (Exception ex)
            {
                response.Message = "Ocurrió un error";
                response.ErrorMessage = ex.Message;
                response.Status = System.Net.HttpStatusCode.InternalServerError;
            }
            return response;
        }

        //[WebMethod]
        //[ScriptMethod(UseHttpGet = false)]
        //public static Response HasMessageOninit()
        //{
        //    string message = MessegeOnInit;
        //    Response response = new Response();
        //    response.Status = string.IsNullOrEmpty(message) ? System.Net.HttpStatusCode.NotFound : System.Net.HttpStatusCode.Found;
        //    response.Message = message;
        //    MessegeOnInit = string.Empty;
        //    return response;
        //}
        //#endregion

        //#region Metodos
        //public static Response ChageProfileUserLogin(string user, string pass, int level)
        //{
        //    HttpContext.Current.Session.Clear();
        //    return autentication(user, pass, level);
        //}

        public static Response autentication(string user, string pass, int level)
        {
            try
            {
                user = user.Replace("'", "");
                pass = pass.Replace("'", "");
                if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
                    return new Response(System.Net.HttpStatusCode.BadRequest, "Faltan campos por llenar");

                Framework.Business.UserBAL UserBAL = new Framework.Business.UserBAL() { ConnectionString = Framework.Global.ProjectConnection.CredentialsConnectionString };
                if (!UserBAL.UserExists(user, pass))
                    return new Response(System.Net.HttpStatusCode.InternalServerError, "El Usuario y/o Contraseña son incorrectos");
                Framework.Core.UserInfo Login = UserBAL.GetUser(user);
                Framework.Global.UserInfo = Login;

                string urlToRedirect = "/Default.aspx";

                var tkt = new FormsAuthenticationTicket(1, Login.Nombre.ToUpper().ToString().Trim(), DateTime.Now, DateTime.Now.AddMinutes(240), true, "your custom data");
                var cookiestr = FormsAuthentication.Encrypt(tkt);
                var ck = new HttpCookie(FormsAuthentication.FormsCookieName, cookiestr)
                {
                    Expires = tkt.Expiration,
                    Path = FormsAuthentication.FormsCookiePath
                };
                HttpContext.Current.Response.Cookies.Add(ck);
                FormsAuthentication.SetAuthCookie(Login.Nombre, false);

                HttpContext.Current.Session["LoginUser"] = Login;
                HttpContext.Current.Session["CurrentUser"] = Login;
                HttpContext.Current.Session["UserId"] = Login.Id;
                var response = new Response(System.Net.HttpStatusCode.Redirect, "Sesión iniciada")
                {
                    Redirect = urlToRedirect
                };
                
                MessegeOnInit = $"Sesión iniciada como: {Login.Nombre.ToString()}";
                return response;
            }
            catch (Exception ex)
            {
                var response = new Response(System.Net.HttpStatusCode.InternalServerError, "Ha ocurrido un error. Por favor contacte con el administrador")
                {
                    ErrorMessage = ex.Message
                };
                return response;
            }
        }
        #endregion
    }

    public class Response
    {
        public object Data { get; set; }
        public HttpStatusCode Status { get; set; }
        public string Message { get; set; }
        public string ErrorMessage { get; set; }
        public string Redirect { get; set; }
        public int Total { get; set; }
        public int Pages { get; set; }

        public Response(HttpStatusCode status, string message)
        {
            Status = status; Message = message;
        }

        public Response()
        {
            Status = HttpStatusCode.OK; Message = "Success";
        }
    }
}
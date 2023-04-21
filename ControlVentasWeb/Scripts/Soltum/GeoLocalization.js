function GetLocation(){
    const geolocation = navigator.geolocation

    geolocation.getCurrentPosition(getPosition, error, options)
}

const options = {
    enableHightAccuracy: true,
    timeout: 5000,
    maximunAge: 0
}

const getPosition = (position) => {
    //console.log(position)
    //console.log(position.coords.latitude)
    //console.log(position.coords.longitude)
    SendLocationForLogin(position.coords.latitude + "", position.coords.longitude + "")
}

const error = (error) => console.log(error)

function SendLocationForLogin(latitude, longitude) {
    //console.log(latitude, longitude);
    var URL = '/Account/Login.aspx/SetLocation';
    //console.log(URL);

    api_service.postWithParams(URL, { Latitude: latitude, Longitude: longitude } , function (response, data, object) {
        if (response.d.Status == 200) {
            console.log(response.d.Message);
            //$("#btnLogin").focus();
            //bootstrap_alert.success(response.d.Message);
            //window.location = response.d.Redirect;
        //} else if (response.d.Status == 403) {
        //    bootstrap_alert.info(response.d.Message);
        //} else if (response.d.Status == 400) {
        //    bootstrap_alert.warning(response.d.Message);
        } else {
            //bootstrap_alert.error(response.d.Message);
            console.log(response.d.ErrorMessage);
        }
    });
}
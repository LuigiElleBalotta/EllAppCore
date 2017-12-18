$("#avviso").hide();
$("document").ready(function ()
{
    $("#inviaModuloCreazioneAccount").click(function (e)
    {
        e.preventDefault();
        $("#inviaModuloCreazioneAccount").button("loading");
        var username = $("#user").val().trim();
        var password = $("#psw").val().trim();
        var email = $("#email").val().trim();
        var emailok = false;
        if (isValidEmail(email))
            emailok = true;
        if (username === "" || password === "" || email === "") {
            $("#inviaModuloCreazioneAccount").button("reset");
            $("#risultato").html("Errore nella creazione dell'account");
            $("#avviso").show(300);
            setTimeout(resetAvviso, 3000);
            return false;
        }
        else {
            if (!emailok) {
                $("#inviaModuloCreazioneAccount").button("reset");
                $("#risultato").html("Email non valida");
                $("#avviso").show(300);
                setTimeout(resetAvviso, 3000);
                return false;
			}

            var regObj = new Object();
            regObj.Type = 4;
            regObj.RegistrationPacket = {
                Username: username,
                Psw: password,
                Email: email
            };
            regObj = JSON.stringify(regObj);

            $.ajax({
                url: "http://localhost/60558/SendData/",
                success: function (result)
                {
                    var msg = "";
                    var canGoOn = false;
                    if (result !== "") {
                        alert(result);
                        return;
                        /*var obj = JSON.parse(result);
                        switch (parseInt(obj.MessageType)) {
                        case 5:
                            if (obj.data.Result) {
                                msg = "Success!";
                                canGoOn = true;
                            } else
                                msg = "Failure!";
                            break;
                        default: //Throw away everything else
                            break;
                        }
                        $("#risultato").html(msg);
                        $("#avviso").show(300);
                        $("#inviaModuloCreazioneAccount").button("reset");
                        if (!canGoOn)
                            setTimeout(resetAvviso, 3000);
                        else
                            setTimeout(function() { window.location.href = "../login/login.html"; }, 100);*/
                    }
                },
                method: 'POST',
                data: { data: regObj }
            });
        }
    });

    function resetAvviso() {
        $("#avviso").hide(300);
        $("#risultato").html("");
    }

    function isValidEmail(emailAddress) {
        var pattern = new RegExp(/^(("[\w-\s]+")|([\w-]+(?:\.[\w-]+)*)|("[\w-\s]+")([\w-]+(?:\.[\w-]+)*))(@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$)|(@\[?((25[0-5]\.|2[0-4][0-9]\.|1[0-9]{2}\.|[0-9]{1,2}\.))((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\.){2}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\]?$)/i);
        return pattern.test(emailAddress);
    };
});
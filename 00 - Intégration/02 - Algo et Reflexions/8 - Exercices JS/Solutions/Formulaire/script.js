/*************V1 input nommé******************* */

// nom = document.getElementById("nom");
// nom.addEventListener("input",verifNom);
// regexNom = new RegExp("^[a-z]+$");
// zoneMessage = document.querySelector(".message");

// function verifNom()
// {
//    if (regexNom.test(nom.value))
//    {
//     zoneMessage.innerHTML = "super"
//    }
//    else{
//     zoneMessage.innerHTML="ko"
//    }
// }

/*************V2 tous les inputs ******************* */

// lesInputs = document.querySelectorAll("input");
// lesInputs.forEach(element => {
//     element.addEventListener("input",verifInput);
// });

// function verifInput(e)
// {
//     regex = new RegExp(e.target.getAttribute("pattern"));
//     zoneMessage = e.target.nextElementSibling;

//    if (regex.test(e.target.value))
//    {
//     zoneMessage.innerHTML = "super"
//    }
//    else{
//     zoneMessage.innerHTML="ko"
//    }
// }

/*************V3 utilisation pattern HTML ******************* */

lesInputs = document.querySelectorAll("input");
lesInputs.forEach(element => {
    element.addEventListener("input",verifInput);
});

function verifInput(e)
{
    zoneMessage = e.target.nextElementSibling;

   if (e.target.checkValidity())
   {
    zoneMessage.innerHTML = "super"
   }
   else{
    zoneMessage.innerHTML="ko"
   }
}

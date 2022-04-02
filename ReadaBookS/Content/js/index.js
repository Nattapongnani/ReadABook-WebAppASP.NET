window.onscroll = function () { scrollFunction() };

function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        document.querySelector(".navbar").style.border = "1px solid rgb(226, 226, 226)";
        document.querySelector(".navbar").style.background = "white";
        document.querySelector(".navbar").style.transition = "0.8s";
        document.querySelector(".navbarjs1").style.color = "black";
        document.querySelector(".navbarjs2").style.color = "black";
        document.querySelector(".navbarjs3").style.color = "black";

    } else {
        document.querySelector(".navbar").style.border = "none";
        document.querySelector(".navbar").style.background = "rgb(33, 37, 41)";
        //document.querySelector(".nav-link").style.color = "white";
        document.querySelector(".navbarjs1").style.color = "white";
        document.querySelector(".navbarjs2").style.color = "white";
        document.querySelector(".navbarjs3").style.color = "white";
    }
}
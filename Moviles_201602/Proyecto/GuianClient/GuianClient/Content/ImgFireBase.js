/*
// Initialize Firebase
var config = {
    apiKey: "AIzaSyA7eSO7zw0hUYERFy0B_rJ6-Q2rjpKk_Vw",
    authDomain: "upcmobdev201602wx71-7e6c3.firebaseapp.com",
    databaseURL: "https://upcmobdev201602wx71-7e6c3.firebaseio.com",
    storageBucket: "upcmobdev201602wx71-7e6c3.appspot.com"

};

firebase.initializeApp(config);

//script don lusho
var storage = firebase.storage();

var storageRef = storage.ref('donlusho3.jpg');

// Get the download URL
storageRef.getDownloadURL().then(function (url) {
    var test = url;

    document.querySelector('img').src = test;
});*/


document.onreadystatechange = function () {
    document.getElementById("mycircle").src = "https://firebasestorage.googleapis.com/v0/b/upcmobdev201602wx71-7e6c3.appspot.com/o/Principal%2FPrincipal%2Fcircle.png?alt=media&token=49ac19cc-a353-4228-bf4a-9774b054dd1a";
    document.getElementById("mymap").src = "https://firebasestorage.googleapis.com/v0/b/upcmobdev201602wx71-7e6c3.appspot.com/o/Principal%2FPrincipal%2Fmap.svg?alt=media&token=1d7d9eb3-03a1-4b06-afd8-f8936a4ed8a0";
    document.getElementById("myaudio").src = "https://firebasestorage.googleapis.com/v0/b/upcmobdev201602wx71-7e6c3.appspot.com/o/Principal%2FPrincipal%2Faudio.png?alt=media&token=f6f54db7-b2db-4a51-a730-2308d44441b0";
    document.getElementById("mymachu").src = "https://firebasestorage.googleapis.com/v0/b/upcmobdev201602wx71-7e6c3.appspot.com/o/Principal%2FPrincipal%2Fmachu.jpg?alt=media&token=b8bd42d6-3b27-4246-a3b7-f40ac1a52897";
    document.getElementById("mymachu2").src = "https://firebasestorage.googleapis.com/v0/b/upcmobdev201602wx71-7e6c3.appspot.com/o/Principal%2FPrincipal%2Fmachu.jpg?alt=media&token=b8bd42d6-3b27-4246-a3b7-f40ac1a52897";
    document.getElementById("myiphone").src = "https://firebasestorage.googleapis.com/v0/b/upcmobdev201602wx71-7e6c3.appspot.com/o/Principal%2FPrincipal%2Fiphone.gif?alt=media&token=5384f1a7-60e8-48c6-aa6c-c4f88dd40f17";
    document.getElementById("myshare").src = "https://firebasestorage.googleapis.com/v0/b/upcmobdev201602wx71-7e6c3.appspot.com/o/Principal%2FPrincipal%2Fshare.ico?alt=media&token=8bdbe6e1-2c7b-49c6-9c47-4443c8475468";
    document.getElementById("myoffline").src = "https://firebasestorage.googleapis.com/v0/b/upcmobdev201602wx71-7e6c3.appspot.com/o/Principal%2FPrincipal%2Foffline.png?alt=media&token=1c813fe9-d156-4484-8e9e-80421ebdaada";
    document.getElementById("myqr").src = "https://firebasestorage.googleapis.com/v0/b/upcmobdev201602wx71-7e6c3.appspot.com/o/Principal%2FPrincipal%2Fqr.jpg?alt=media&token=e4e55f4e-d6b0-4894-87f4-2ac781b2dedb";
    document.getElementById("mycoliseo").src = "https://firebasestorage.googleapis.com/v0/b/upcmobdev201602wx71-7e6c3.appspot.com/o/Principal%2FPrincipal%2Fcoliseo.jpg?alt=media&token=e0eed342-63af-4500-82fd-92f2d1cdfe1f";
    document.getElementById("mypisa").src = "https://firebasestorage.googleapis.com/v0/b/upcmobdev201602wx71-7e6c3.appspot.com/o/Principal%2FPrincipal%2Fpisa.jpg?alt=media&token=2bb2b822-54f7-42cd-bfce-0965802d4ada";
    document.getElementById("myslide1").src = "https://firebasestorage.googleapis.com/v0/b/upcmobdev201602wx71-7e6c3.appspot.com/o/Principal%2FPrincipal%2F1.png?alt=media&token=c85fbaac-f80e-4da6-9e00-022b95b8a359";
    document.getElementById("myslide2").src = "https://firebasestorage.googleapis.com/v0/b/upcmobdev201602wx71-7e6c3.appspot.com/o/Principal%2FPrincipal%2F2.png?alt=media&token=869bc303-f690-45c0-99cd-1d4b7b1de784";
    document.getElementById("myslide3").src = "https://firebasestorage.googleapis.com/v0/b/upcmobdev201602wx71-7e6c3.appspot.com/o/Principal%2FPrincipal%2F3.png?alt=media&token=5ca46e32-9e26-4ba4-ad02-3ad42c2ae115";
    document.getElementById("myslide4").src = "https://firebasestorage.googleapis.com/v0/b/upcmobdev201602wx71-7e6c3.appspot.com/o/Principal%2FPrincipal%2F4.png?alt=media&token=d23a3b34-84f7-422d-89a7-11566ac17bbc";
    document.getElementById("myslide5").src = "https://firebasestorage.googleapis.com/v0/b/upcmobdev201602wx71-7e6c3.appspot.com/o/Principal%2FPrincipal%2F5.png?alt=media&token=1183cf16-1468-4d15-8e4b-70b38a0ab334";
    document.getElementById("myslide6").src = "https://firebasestorage.googleapis.com/v0/b/upcmobdev201602wx71-7e6c3.appspot.com/o/Principal%2FPrincipal%2F6.png?alt=media&token=60f2dfe2-2a1b-418b-abf3-f26a27e3ecca";

}

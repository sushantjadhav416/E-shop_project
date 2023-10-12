var c = 0;
function mycart() {
    alert("The iteam is added to your cart");
    c++;
    document.getElementById("crt").innerHTML = " +" + c;
}
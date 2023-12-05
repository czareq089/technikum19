let a = prompt("Bok pierwszy: ")
let b = prompt("Bok drugi: ")
// let c = prompt("Bok C: ")


let iloczyn = a*a + b*b;
let pierwiastek = Math.sqrt(iloczyn)
if((pierwiastek.isInteger)){
    alert("Bok trzeci wynosi: " + pierwiastek.toFixed(0));
} else{
    alert("Bok trzeci wynosi: " + pierwiastek.toFixed(2));}






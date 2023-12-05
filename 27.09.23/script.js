let login = prompt()
let pass = prompt()
let haslo=pass.charCodeAt(0)
if(login == "admin" && haslo == 56)
{
    document.write("sukces")
}
else{
    alert("błędny login lub hasło")
}
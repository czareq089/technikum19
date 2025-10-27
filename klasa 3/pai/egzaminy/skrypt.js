document.getElementById("submit").addEventListener("click", () => {
    document.getElementById("wynik").innerText = "Potrzebne puszki : " + Math.ceil(document.getElementById("ilosc").value / 4)
});
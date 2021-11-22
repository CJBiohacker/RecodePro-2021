console.log("Ola mundo!!!");

var celular = document.querySelectorAll(".celular");

console.log(celular.length);

for( var i = 0; i < celular.length; i++){
    var celcularipx = celular[i]

    var precoIPX = celcularipx.querySelector(".info-preco");
    var preco = precoIPX.textContent;

    console.log(preco)

    var descontoIPX = celcularipx.querySelector(".info-desconto");

    var desconto = descontoIPX.textContent;
    var desconto = desconto/100;

    console.log(desconto);

    var calculoTotal = preco - (preco * desconto);

    console.log(calculoTotal);

    var total = celcularipx.querySelector(".info-total");

    var precoVal = true;
    var descVal = true;
    
    if (preco > 10000 || preco < 0){
        total.textContent = "Preço invalido"
        console.log("Preço invalido!!!")
        //celularipx.style.color = "red"
        celcularipx.classList.add("dados-invalidos")
        precoVal = false;

    }
    if (descontoIPX.textContent > 100 || descontoIPX.textContent < 0){
        total.textContent = "Desconto invalido"
        console.log("Desconto invalido")
        //celularipx.style.backgroundColor = "red"
        celcularipx.classList.add("dados-invalidos")
        descVal = false;
    }
    if (precoVal && descVal){
        total.textContent = calculoTotal.toFixed(2);
    }

}

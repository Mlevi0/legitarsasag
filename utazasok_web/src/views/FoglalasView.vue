<template>
    <div class="foglalas container">
      <div class="row">
        <div class="col-md-12">
          <h1 class="text-center">Foglalás</h1>
          <p>Az utazás évezredek óta az emberiség működésének része, a hajtóereje. Ha nincsenek például a hódító arabok, vagy a kalandvágyó magyarok ősei, ha nincsenek a vikingek, ha nincsen Kolumbusz Kristóf és Magellán, ha nincsen az a sok tettre kész, szinte őrülten elszánt, névtelen tengerész és kevésbé ismert megannyi szárazföldi felfedező, akik sokszor életük árán is menni akartak, megismerni új világokat, meghódítani új földeket, nem is tudom… talán még mindig azt gondolnánk, hogy a Föld lapos... Az utazás szerintem elidegeníthetetlen része a fejlődésnek. Persze vannak olyan emberek, akik inkább a biztonságot adó otthonukat és a már megismert, kipróbált közeli helyeket szeretik, vagy csak egyszerűen nem vágynak arra, hogy messzi tájakat hódítsanak meg, mert ők így érzik jól magukat a saját környezetükben. </p>
        </div>
      </div>
      <div class="row my-3">
        <div class="col-md-2">
          <div class="kartya">
          <img src="/becs.jpg" alt="Bécs" style="width: 100%;">
          <div class="container">
            <p class="h4">Bécs</p>
          </div>
        </div>
        </div>
        <div class="col-md-2">
          <div class="kartya">
          <img src="/berlin.jpg" alt="Berlin" style="width: 100%; ">
          <div class="container">
            <p class="h4">Berlin</p>
          </div>
        </div>
        </div>
        <div class="col-md-2">
          <div class="kartya">
          <img src="/bern.jpg" alt="Bern" style="width: 100%;">
          <div class="container">
            <p class="h4">Bern</p>
          </div>
        </div>
        </div>
        <div class="col-md-2">
          <div class="kartya">
          <img src="/dublin.jpeg" alt="Dublin" style="width: 100%;">
          <div class="container">
            <p class="h4">Dublin</p>
          </div>
        </div>
        </div>
        <div class="col-md-2">
          <div class="kartya">
          <img src="/helsinki.jpg" alt="Helsinki" style="width: 100%;">
          <div class="container">
            <p class="h4">Helsinki</p>
          </div>
        </div>
        </div>
        <div class="col-md-2">
          <div class="kartya">
          <img src="/london.jpg" alt="London" style="width: 100%;">
          <div class="container">
            <p class="h4">London</p>
          </div>
        </div>
        </div>
      </div>
      <div class="row">
        <div class="col-md-2">
          <div class="kartya">
          <img src="/koppenhaga.jpeg" alt="Koppenhága" style="width: 100%;">
          <div class="container">
            <p class="h4">Koppenhága</p>
          </div>
        </div>
        </div>
        <div class="col-md-2">
          <div class="kartya">
          <img src="/oslo.jpg" alt="Oslo" style="width: 100%;">
          <div class="container">
            <p class="h4">Oslo</p>
          </div>
        </div>
        </div>
        <div class="col-md-2">
          <div class="kartya">
          <img src="/reykjavik.jpg" alt="Reykjavík" style="width: 100%;">
          <div class="container">
            <p class="h4">Reykjavík</p>
          </div>
        </div>
        </div>
        <div class="col-md-2">
          <div class="kartya">
          <img src="/stockholm.jpeg" alt="Stockholm" style="width: 100%;">
          <div class="container">
            <p class="h4">Stockholm</p>
          </div>
        </div>
        </div>
        <div class="col-md-2">
          <div class="kartya">
          <img src="/budapest.jpg" alt="Budapest" style="width: 100%;">
          <div class="container">
            <p class="h4">Budapest</p>
          </div>
        </div>
        </div>
        <div class="col-md-2">
          <div class="kartya">
          <img src="/parizs.jpg" alt="Párizs" style="width: 100%;">
          <div class="container">
            <p class="h4">Párizs</p>
          </div>
        </div>
        </div>
      </div>
      <div class="container rounded shadow-md my-5">
        <form> 
          <div class="row">
            <h1 class="text-center">Űrlap</h1> 
            <div class="col-md-2 pe-0 col-sm-12 offset-md-2"> 
              <div class="btn radio-btn mb-3"> 
                <label class="radio"> 
                <input type="radio" value="odavissza" name="tipus" checked>Oda-vissza<span></span> </label> 
              </div> 
            </div> 
            <div class="col-md-2 pe-0 col-sm-12 offset-md-4">
               <div class="btn radio-btn mb-3"> 
                <label class="radio"> <input type="radio" value="oda" name="tipus"> Oda <span></span> </label> 
              </div> 
            </div> 
          </div> 
          <div class="row"> 
            <div class="col-md-6 col-12 mb-4"> 
              <div class="form-control d-flex flex-column"> 
                <p class="h-blue">Honnan</p> <input class="inputbox" placeholder="Város" type="text" id="honnanvaros"> 
              </div> 
            </div> 
            <div class="col-md-6 col-12 mb-4"> 
              <div class="form-control d-flex flex-column">
                <p class="h-blue">Hova</p> <input class="inputbox" placeholder="Város" type="text" id="hovavaros"> 
              </div> 
            </div> 
          </div> 
          <div class="row">
            <div class="col-md-6 col-12 mb-4"> 
              <div class="form-control d-flex flex-column"> 
                <p class="h-blue">Indulás</p> <input class="inputbox textmuted" type="date" id="indulas"> 
              </div> 
            </div> 
            <div class="col-md-6 col-12 mb-4"> 
              <div class="form-control d-flex flex-column"> 
                <p class="h-blue">Érkezés</p> <input class="inputbox textmuted " type="date" id="erkezes"> 
              </div> 
            </div> 
          </div> 
          <div class="row"> 
            <div class="col-md-4 mb-4"> 
              <div class="form-control d-flex flex-column"> 
                <p class="h-blue">Felnőttek (18+)</p> <input type="number" name="felnottekszama" id="felnottekszama" class="border-0">
              </div> 
            </div> 
            <div class="col-md-4 mb-4"> 
              <div class="form-control d-flex flex-column">
                <p class="h-blue">Gyerekek (0-16)</p>
                <input type="number" name="gyerekekszama" id="gyerekekszama" class="border-0">
              </div> 
            </div> 
            <div class="col-md-4 mb-4"> 
              <div class="form-control d-flex flex-column"> 
                <p class="h-blue">Osztályok</p> 
                <select class="border-0 outline-none"> 
                  <option value="" hidden selected></option> <option value="economy">Economy</option> <option value="premium">Premium</option> <option value="business">Business</option> 
                </select> 
              </div>
            </div>
          </div>
          <div class="ertesito"></div>
          <button class="btn btn-primary form-control text-center mb-3" >Foglalás</button> 
        </form> 
      </div>
    </div>
  </template>
 <script setup>
 </script>
  <style>
.kartya {
  box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
  transition: 0.3s;
}

/* On mouse-over, add a deeper shadow */
.kartya:hover {
  box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
}

/* Add some padding inside the card container */
.kartya .container {
  padding: 2px 16px;
}
.box {
    border: 2px solid #ddd;
    padding: 10px 20px
}

.inputbox {
    border: none;
    outline: none
}

.h-blue {
    color: #49bff5;
    margin-bottom: 5px;
    padding-left: 4px;
    font-size: 14px;
    font-weight: 500
}

::placeholder {
    font-size: 18px;
    color: #ddd
}

.textmuted {
    color: #ddd
}

.radio {
    display: inline-block;
    margin-left: 13px;
    cursor: pointer;
    font-weight: 500
}

.btn.radio-btn {
    position: relative
}

.radio input[type="radio"] {
    display: none
}

.radio span {
    height: 20px;
    width: 20px;
    border: 2px solid #ddd;
    border-radius: 50%;
    display: block;
    position: absolute;
    top: 8px;
    left: 0
}

.radio span::after {
    content: "";
    height: 10px;
    width: 10px;
    background-color: #49bff5;
    display: block;
    position: absolute;
    left: 50%;
    top: 50%;
    transform: translate(-50%, -50%) scale(0);
    border-radius: 50%;
    transition: 300ms ease-in-out 0s
}

.radio input[type="radio"]:checked~span::after {
    transform: translate(-50%, -50%) scale(1)
}

.outline-none {
    outline: none
}

.btn.btn-primary {
    height: 60px;
    font-size: 20px;
    padding: 10px
}

@media (max-width:820px) {
    body {
        padding: 20px
    }
}
  </style>
  
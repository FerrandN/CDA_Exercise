import { Zipcodes } from "./Zipcodes.js";

const zip = new Zipcodes();
const regNomVille = new RegExp('^[A-z -\']{2,}$');
const regCodePostaux = new RegExp('^[0-9]{2,5}$');
await zip.load().then(() => {
    document.querySelector('#searchbar').addEventListener('keyup', e =>{
        if (regNomVille.test(e.target.value)){
            genererOptionNomCommune();
        } else if (regCodePostaux.test(e.target.value)){
            genererOptionCodesPostaux();
        }
    });
    document.querySelector('#benjibt').addEventListener('click', ()=>chargerDonees());
});

function chargerDonees(){
    let el = document.querySelector('#searchbar');
    let datas = [];
    if (regNomVille.test(el.value)){
        datas = getNomCommune();
    } else if (regCodePostaux.test(em.value)){
        datas = getCodePostaux();
    }
    console.log('datas =>');
    console.log(datas);
    ajouterDivElement(datas);
}

function ajouterDivElement(datas){
    
    let div = document.querySelector('#results');
    div.innerHTML = "";
    datas.forEach(d => div.innerHTML += '<p>Code postal : ' + d.codePostal + ', nomCommune: ' + d.nomCommune + '</p>'); 
}

function genererOptionCodesPostaux(){
    let datas  = getCodePostaux();
    ajouterElementEnOption(extractOnlyCodesPostaux(datas));

}

function genererOptionNomCommune(){
    let datas = getNomCommune();
    console.log(datas);
    ajouterElementEnOption(extractOnlyNomCommune(datas));
}

function ajouterElementEnOption(datas){
    //console.log(datas);
    let dl  = document.querySelector('#hintlist');
    
    dl.innerHTML = "";
    datas.forEach(d=> {
        let option = document.createElement('option');
        option.value = d;
        dl.appendChild(option);
    });
}

function extractOnlyCodesPostaux(datas){
    let rt = [];
    datas.forEach(d=> rt.push(d.codePostal));
    return rt;
}

function extractOnlyNomCommune(datas){
    let rt = [];
    datas.forEach(d=> rt.push(d.nomCommune));
    return rt;
}



function getCodePostaux(){
    let v = document.querySelector('#searchbar').value;
    
    let datalist = [];
    let i = 0;
    zip.datas.forEach(d=> {
        if (d.codePostal.includes(v)){
            datalist.push(d);
        }
    });
    return datalist;
}

function getNomCommune(){
    let v = document.querySelector('#searchbar').value;
    
    let datalist = [];
    zip.datas.forEach(d=> {
        if (d.nomCommune.includes(v)){
            datalist.push(d);
        }
    });

    return datalist;
}
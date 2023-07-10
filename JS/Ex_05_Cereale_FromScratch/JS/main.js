import {Cereals} from "./cereals.js";
import {TableGenerator} from "./tableGenerator.js"

let cereals = new Cereals();
await cereals.loadData();

let cerealsTable = new TableGenerator(cereals);
cerealsTable.generateHeader();
cerealsTable.generateTable();

document.getElementById("calories").addEventListener("click", (event) =>{
    cereals.sortByCalories();
    cerealsTable.generateTable();
});

document.getElementById("protein").addEventListener("click", (event) =>{
    cereals.sortByProtein();
    cerealsTable.generateTable();
});

document.getElementById("name").addEventListener("click", (event) =>{
    cereals.sortByname();
    cerealsTable.generateTable();
});

document.getElementById("searchField").addEventListener("input", async (event) =>{
    //contient la valeur du champ lorsque l'évenement est déclenché
    let searchFieldValue = event.target.value;

    await cereals.searchByName(searchFieldValue);
    
    //regenère le tableau
    cerealsTable.generateTable();
});
begikas1 = window.prompt("Iveskite 1 begiko varda:", "");
vieta1 = window.prompt("Iveskite 1 begiko finiso vieta:", 0);
begikas2 = window.prompt("Iveskite 2 begiko varda:", "");
vieta2 = window.prompt("Iveskite 2 begiko finiso vieta:", 0);
begikas3 = window.prompt("Iveskite 3 begiko varda:", "");
vieta3 = window.prompt("Iveskite 3 begiko finiso vieta:", 0);
begikas4 = window.prompt("Iveskite 4 begiko varda:", "");
vieta4 = window.prompt("Iveskite 4 begiko finiso vieta:", 0);

medalis1 = vieta1.replace("1", "aukso").replace("2", "sidabro").replace("3", "bronzos").replace("4", "medini");
console.log(begikas1 + " laimejo " + medalis1 + " medali.");
medalis2 = vieta2.replace("1", "aukso").replace("2", "sidabro").replace("3", "bronzos").replace("4", "medini");
console.log(begikas2 + " laimejo " + medalis2 + " medali.");
medalis3 = vieta3.replace("1", "aukso").replace("2", "sidabro").replace("3", "bronzos").replace("4", "medini");
console.log(begikas3 + " laimejo " + medalis3 + " medali.");
medalis4 = vieta4.replace("1", "aukso").replace("2", "sidabro").replace("3", "bronzos").replace("4", "medini");
console.log(begikas4 + " laimejo " + medalis4 + " medali.");
const url = 'https://swapi.dev/api/films'
/*
const getFilm =(filmNo) => fetch(url)
    .then(res => res.json())
    .then(data => {
        return data.results[filmNo]
    });

for(let i = 0; i < 6; i++) {
    getFilm(i).then(f => console.log(f));
}
*/
const getFilmAsync = async (filmNo) => {
    const response = await fetch(url)
    const data =  await response.json()
    return data.results[filmNo]
}

const logFilm = async (filmNo) => {
    const film = await getFilmAsync(filmNo)
    console.log(film)
}

const addFilm = async filmNo => {
    const film = await getFilmAsync(filmNo)
    let text
    for (let key in film) {
        if(key === 'characters') {
            text += `${key}: <br>`
            ch = film[key]
            for(let a in ch) {
                text += `<ul>${ch[a]}</ul>`
            }
        }
        else {
            text += `${key}: ${film[key]}<br>`
        }
    }
    filmList.innerHTML += `<div class="filmDesc">${text}</div>`
    //const text = JSON.stringify(film).replaceAll('\\r\\n', '<br>')
    //filmList.innerHTML += `<p>${text}</p>`
}

for(let i = 0; i < 6; i++) {
    //logFilm(i)
    addFilm(i)
}

const urlMeteo = 'https://api.meteo.lt/v1/places'
const options = { 
    mode: 'no-cors' // 'cors' by default
}

const getMeteo = async () => {
    const response = await fetch(urlMeteo, options)
    const data =  await response.json()
    console.log(response)
}

//getMeteo()
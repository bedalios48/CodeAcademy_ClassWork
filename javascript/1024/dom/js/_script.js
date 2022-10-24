function changeFirstLi() {
    const ul = document.getElementsByName('ul')[0];
    const kavos_li = ul.getElementsByTagName('li')[0];
    kavos_li.innerHTML += ' Kitas gerimas';
}

function addMilkLi() {
    const ul = document.getElementsByTagName('ul')[0];
    ul.innerHTML += `<li class="drink milk">Milk</li>`;
}

function countLi() {
    const ul = document.getElementsByTagName('ul')[0];
    const li_count = ul.children.length;
    return `ul has ${li_count} items`;
}

function changeCoffee() {
    const li = document.getElementsByClassName("coffee")[0];
    li.innerHTML = `Karstas sokoladas`;
}

function changeMilkToAlmondMilk() {
    const list_of_li = document.getElementsByClassName('milk');
    for (const li of list_of_li) {
        li.innerHTML = "Migdolu gerimas";
    }
}

function changeStyleOfWater() {
    const list_of_li = document.getElementsByClassName('water');
    for (const li of list_of_li) {
        li.style.backgroundColor = 'blue';
    }
}

function changeStyleOfMilk() {
    const list_of_li = document.getElementsByClassName('milk');
    for (const li of list_of_li) {
        if (li.classList.contains('pretty_milk')) {
            li.classList.remove('pretty_milk');
        }
        else {
            li.classList.add('pretty_milk');
        }
    }
}
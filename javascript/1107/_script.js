h = 20;
m = 0;
hour.innerHTML = h;
minute.innerHTML = m;
s = 0;
setInterval(() => {
    second.innerHTML = s;
    minute.innerHTML = m;
    hour.innerHTML = h;
    s++;
    if (s === 60) {
        s = 0;
        m++;
        if (m === 60) {
            m = 0;
            h++;
            if (h === 24) {
                h = 0;
            }
        }
    }
}, 1000);

const pizzaToppings = (toppingsArr) => {
    return new Promise((resolve, reject) => {
        if(toppingsArr.includes('pineapple')) {
            reject("pineapple is bad");
        } else {
            resolve("pizza ingredients: " + toppingsArr.join(', '));
        }
    });
};

let toppings = ['cheese', 'ham', 'tomatoes', 'pineapple'];
pizzaToppings(toppings).then(res => console.log(res)).catch(err => console.log(err));
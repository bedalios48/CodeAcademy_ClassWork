const arr = ["I", "study", "JavaScript", "right", "now"];

function LetsDance(arr) {
    arr.splice(0, 3, "Lets", "dance");
    console.log(arr.join(' '));
}

let first = ['slice', 'splice', 'concat'];
let second = ['push', 'pop', 'shift', 'unshift'];

let all = first.concat(second);
all.push('length', 7, {
    subject: 'methods'
});

console.log(all);

let accords = ["D", "G", "C", "C7", "F"]
function updateAccord(accord) {
    if(!accord.endsWith('7')) {
        accord += '7';
    }
    return accord;
    // console.log(accord);
}

for (let i = 0; i < accords.length; i++) {
    console.log(updateAccord(accords[i]));
}
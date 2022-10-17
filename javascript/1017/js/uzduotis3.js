a = window.prompt("Iveskite skaiciu a:", "0");
console.log(a);
b = window.prompt("Iveskite skaiciu b:", "0");
console.log(b);
c = window.prompt("Iveskite skaiciu c:", "0");
console.log(c);
d = window.prompt("Iveskite skaiciu d:", "0");
console.log(d);
f = window.prompt("Iveskite skaiciu f:", 0);
console.log(f);

if (a>b && a>c && a>d && a>f) {
    letter = a;
  } else if (b>a && b>c && b>d && b>f) {
    letter = b;
  } else if (c>a && c>b && c>d && c>f) {
    letter = c;
  } else if (d>a && d>c && d>b && d>f) {
    letter = d;
  }
  else {
    letter = f;
  }
  console.log(letter);
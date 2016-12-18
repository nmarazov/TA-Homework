function solve (arg) {
  var a = +arg;

  if (!(a % 5) && !(a % 7)) {
    console.log('true ' + a);
  }
  else {
    console.log('false ' + a);
  }
}

solve('35');
solve('3');
solve('140');
solve('5');

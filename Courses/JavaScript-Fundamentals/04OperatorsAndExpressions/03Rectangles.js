function solve (arguments) {
  var a       = +arguments[0];
      b       = +arguments[1];
      area    = a * b;
      perimet = 2 * (a + b);
  console.log(area.toFixed(2) + ' ' + perimet.toFixed(2));
}

solve(['2.5', '3']);

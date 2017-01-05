function solve (argument) {
  var a = +argument[0]
  var b = +argument[1]
  var area = a * b
  var perimet = 2 * (a + b)
  console.log(area.toFixed(2) + ' ' + perimet.toFixed(2))
}

solve(['2.5', '3'])

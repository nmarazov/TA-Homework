function solve (args) {
  var x = +args[0]
  var y = +args[1]
  var result = ''
  var distance = Math.sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1))

  if (distance <= 1.5) {
    result = 'inside circle'
  } else {
    result = 'outside circle'
  }

  if ((x >= -1 && x <= 5) && (y <= 1 && y >= -1)) {
    result += ' inside rectangle'
  } else {
    result += ' outside rectangle'
  }

  console.log(result)
}

solve(['2.5', '2'])
solve(['0', '1'])
solve(['2.5', '1'])

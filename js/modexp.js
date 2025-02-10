function modulo(divisor, dividend) {
    let remainder = divisor % dividend;
    let trueModulo = trueMod(divisor, dividend);
    let correct = remainder === trueModulo;

    let output = "";

    if (divisor > -1) output += ` ${divisor} MOD `;
    else output += `${divisor} MOD `;    

    if (dividend > -1) output += ` ${dividend}, OK? ${correct ? "Y" : "N"}.`;
    else output += `${dividend}, OK? ${correct ? "Y" : "N"}.`;

    if (remainder > -1) output += ` R= ${remainder} ,`;
    else output += ` R=${remainder} ,`;

    if (trueModulo > -1) output += ` T= ${trueModulo}`;
    else output += ` T=${trueModulo}`;

    console.log(output);
}

function modulo1(divisor, dividend) {
    let remainder = divisor % dividend;
    let trueModulo = trueMod(divisor, dividend);
    let correct = remainder === trueModulo;

    console.log(` ${divisor} MOD ${dividend}, OK? ${correct ? 'Y' : 'N'}. R= ${remainder}, T= ${trueModulo}.`);
}

function trueMod(divisor,dividend) {
    return ((divisor % dividend) + dividend) % dividend;
}

modulo(10, 3);modulo1(10, 3);
modulo(-10, 3);modulo1(-10, 3);
modulo(10, -3);modulo1(10, -3);
modulo(-10, -3);modulo1(-10, -3);

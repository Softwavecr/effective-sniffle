function modulo(a, b) {
    let remainder = a % b;
    let trueModulo = trueMod(a, b);
    let correct = remainder === trueModulo;

    let output = "";

    if (a > -1) {
        output += ` ${a} MOD `;
    } else {
        output += `${a} MOD `;
    }

    if (b > -1) {
        output += ` ${b}, OK? ${correct ? "Y" : "N"}.`;
    } else {
        output += `${b}, OK? ${correct ? "Y" : "N"}.`;
    }

    if (remainder > -1) {
        output += ` R= ${remainder} ,`;
    } else {
        output += ` R=${remainder} ,`;
    }

    if (trueModulo > -1) {
        output += ` T= ${trueModulo}`;
    } else {
        output += ` T=${trueModulo}`;
    }

    console.log(output);
}

function trueMod(adivisor,bdividend) {
    return ((adivisor % bdividend) + bdividend) % bdividend;
}

modulo(10, 3);
modulo(-10, 3);
modulo(10, -3);
modulo(-10, -3);

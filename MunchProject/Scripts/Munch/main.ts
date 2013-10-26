/// <reference path="../Typings/requirejs/require.d.ts" />
require.config({
    baseUrl: "Scripts/Munch"
});

require(["program"], (program) => {
    program.main();
});

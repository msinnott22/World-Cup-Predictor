﻿$("#createGameBtn").click(function() {
        $.ajax({
            url: "\\Game\\CreateGame",
            method: "POST",
            data: { name: $("#game-name").val(), adminUserId: "" },
            success: function() {
                $("#newGameModal").modal("hide");
            }
        });
});

$("#copyJoinCodeBtn").click(function() {
    var copyText = document.getElementById("joinCode");
    copyText.select();
    document.execCommand("copy");

    $("#copySuccessMsg").show();
});
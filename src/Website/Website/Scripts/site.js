$("#createGameBtn").click(function() {
        $.ajax({
            url: "\\Game\\CreateGame",
            method: "POST",
            data: { name: $("#game-name").val(), adminUserId: "" },
            success: function() {
                $("#newGameModal").modal("hide");
            }
        });
    });
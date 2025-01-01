
    $('#clearCacheButton').on('click', function () {
        $.ajax({
            url: '/Cache/Clear',
            type: 'POST',
            success: function (response) {
                alert('Cache cleared successfully!');
            },
            error: function (error) {
                alert('Error clearing cache.');
            }
        });
    });

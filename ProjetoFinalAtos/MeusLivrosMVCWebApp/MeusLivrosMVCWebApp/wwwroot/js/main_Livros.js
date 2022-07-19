
document.getElementById('formulario').addEventListener('submit', function (form) { form.preventDefault(); validaCampos() });



function validaCampos() {
    console.log('entrou')
    
        
}

function readURL(input) {
    var url = input.value;
    var ext = url.substring(url.lastIndexOf('.') + 1).toLowerCase();
    if (input.files && input.files[0] && (ext == "gif" || ext == "png" || ext == "jpeg" || ext == "jpg")) {
        var reader = new FileReader();


        console.log(input.value)
        console.log(input.files)
        console.log(input.files[0])
        console.log(ext)
        console.log(input.files[0].path);
        console.log(input.value);

         nomeCompletoArquivo = 'https://localhost:7159/imgs/' + input.files[0].name

        document.getElementById("fotoCaminho").value = nomeCompletoArquivo;

       
        reader.onload = function (e) {
            $('#foto').attr('src', 'https://localhost:7159/imgs/' + input.files[0].name);
        }
        reader.readAsDataURL(input.files[0]);
    }
    else {
        $('#foto').attr('src', 'https://localhost:7159/imgs/no-image.png');
    }
}

function ShowSuccessMsg() {
    alert('Gravado com sucesso');
}
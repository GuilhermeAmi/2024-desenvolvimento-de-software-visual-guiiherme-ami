/**  ------>     
 * Componente DEVE retornar APENAS UM elemento HTML
 * Exportar Componente
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * <---- */

import { useEffect } from "react";


function ConsultaCEP(){
    useEffect(() => {
        //Evento de  carregamento do componente
        //Executar código ao Abrir carregar o componente
        //AXIOS - Biblioteca de Requisitos 

        fetch("https://viacep.com.br/ws/83306080/json/")
        .then(resposta => {
            return resposta.json();
        })
        .then(cep => {
            console.log(cep)                                                                              

        });
    });



    return (
        
        
        <div >
            <h1>
                Consulta CEP
            </h1>
        </div>
    );
} 


export default ConsultaCEP;
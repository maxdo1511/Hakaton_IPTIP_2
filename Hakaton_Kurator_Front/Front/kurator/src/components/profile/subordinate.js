"use client"

import icon from "../../../public/profile-placeholder.svg"
import Image from "next/image";
import {handleImageUpload} from "@/hooks/image_module";


const Subordinate  = () => {
    return(
        <div className={"mt-7 border-solid border-2 border-text-inherit p-12 col-span-3"}>
            <h3 className={"text-4xl text-stone-400 mb-5"}>Подчиненные кураторы</h3>
            <div className={"flex justify-evenly"}>
                <div className={"text-3xl mb-5"}>
                    <p>Имя Фамилия<span>*****</span></p>
                </div>
                <div className={"text-3xl mb-5"}>
                    <p>Имя Фамилия<span>*****</span></p>
                </div>
                <div className={"text-3xl mb-5"}>
                    <p>Имя Фамилия<span>*****</span></p>
                </div>
            </div>
        </div>
    )
}


export default Subordinate
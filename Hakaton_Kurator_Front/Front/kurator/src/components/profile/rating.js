"use client"

import "../../css/rating.css"
import icon from "../../../public/profile-placeholder.svg"
import Image from "next/image";
import {handleImageUpload} from "@/hooks/image_module";


export default function Rating({ratings}) {
    return(
        <div className={"border-solid border-2 border-text-inherit col-span-2 p-7"}>
            <h3 className={"text-4xl text-stone-400 mb-5"}>Рейтинг</h3>
            <div className={"flex text-3xl mb-5"}>
                <p >Общий рейтинг: </p><span>{ratings.factor}</span>
            </div>
            <div className={"flex text-3xl mb-5"}>
                <p>Образование: </p><span>{ratings.education}</span>
            </div>
            <div className={"flex text-3xl mb-5"}>
                <p>Soft-skills: </p><span>{ratings.social}</span>
            </div>
            <div className={"flex text-3xl"}>
                <p>Ведение документации: </p><span>{ratings.documents}</span>
            </div>
        </div>
    )
}
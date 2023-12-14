"use client"

import icon from "../../../public/person-ph.svg"
import  "../../css/person.css"
import Image from "next/image";
import {handleImageUpload} from "@/hooks/image_module";


const Person = () => {
    return(
        <div className={"flex border-solid border-2 border-text-inherit p-2.5"}>
            <div className={""}>
                <Image
                    className="pers-ph"
                    src={icon}
                    alt="profil icon"
                    sizes="100%"
                />
            </div>
            <div className={"ml-16 pt-7"}>
                <p className={"text-4xl mb-3"}>Имя Фамилия <span
                    className={"text-3xl before:content-['●'] before:text-4xl before:text-lime-400 float-right"}>Онлайн</span></p>

                <div className={"flex text-2xl mb-7"}>
                    <div className={""}>
                        <p className={"text-slate-500 mb-2"}>Роль:</p>
                        <p>Куратор преподаватель</p>
                    </div>
                    <div className={"ml-10"}>
                        <p className={"text-slate-500 mb-2"}>Группа:</p>
                        <p>группа</p>
                    </div>
                </div>
                <p className={"text-2xl text-slate-500"}>Общий рейтинг: ***** <span>4.49</span></p>
            </div>
        </div>
    )
}


export default Person
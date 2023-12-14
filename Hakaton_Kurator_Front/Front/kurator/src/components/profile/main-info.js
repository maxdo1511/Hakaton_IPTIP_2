"use client"

import "../../css/main-info-icon.css"
import "../../css/main-info.css"
import icon from "../../../public/profile-placeholder.svg"
import Image from "next/image";
import {handleImageUpload} from "@/hooks/image_module";


export default function MainInfo({user_info}){
    return(
        <div className={"flex mt-7 border-solid border-2 border-text-inherit p-2.5 pb-5 col-span-2 justify-around"}>
            <div className={"profile__icon__container"}>
                {icon !== "" &&
                    <Image
                        className="profile__icon"
                        src={icon}
                        alt="profil icon"
                        sizes="100%"
                        fill
                        style={{
                            objectFit: 'cover',
                        }}
                    />
                }
                <input className={"profile__icon__loader"} type="file" accept="image/*" onChange={handleImageUpload}/>
            </div>
            <div className={"ml-16"}>
                <p className={"text-4xl mb-3"}>{user_info.user.firstName} {user_info.user.secondName}</p>
                <div className={"flex text-2xl"}>
                    <div className={""}>
                        <p className={"text-slate-500 mb-7"}>Роль:</p>
                        <p>{user_info.role}</p>
                    </div>
                    <div className={"ml-10"}>
                        <p className={"text-slate-500 mb-7"}>Группа:</p>
                        <p>{user_info.user.studyGroup}</p>
                    </div>
                </div>
            </div>
            <div>
                <span className={"text-3xl justify-self-end before:content-['●'] before:text-4xl before:text-lime-400"}>Онлайн</span>
            </div>
        </div>

    )
}
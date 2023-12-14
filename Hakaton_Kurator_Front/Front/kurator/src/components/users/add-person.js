"use client"

import icon from "../../../public/add-prsn.svg"
import  "../../css/add-person.css"
import Image from "next/image";
import {handleImageUpload} from "@/hooks/image_module";
import PopUpAddPerson from "@/components/users/pop-up-add-person";
import {useState} from "react";
import {OutsideAlerter} from "@/hooks/click-outsite-hook";



const AddPerson = () => {
    const [open, SetOpen] = useState(false);

    return(
        <div className={"static"}>
            <div className={"flex border-solid border-2 border-text-inherit p-4 "}>
                <div className={"container-additionan m-auto mr-0"}>
                    <Image
                        className="add-prsn"
                        src={icon}
                        alt="profil icon"
                        sizes="100%"
                        onClick={() => SetOpen(true)}
                    />
                </div>
                <div className={"container-additionan m-auto ml-7"}>
                    <span className={"text-4xl"}>Добавить пользователя</span>
                </div>
            </div>
            <OutsideAlerter onOutside={() => SetOpen(false)}>
                {
                    open && <PopUpAddPerson/>
                }
            </OutsideAlerter>
        </div>
    )
}


export default AddPerson